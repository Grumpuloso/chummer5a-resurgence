/*  This file is part of Chummer5a.
 *
 *  Chummer5a is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  Chummer5a is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with Chummer5a.  If not, see <http://www.gnu.org/licenses/>.
 *
 *  You can obtain the full source code for Chummer5a at
 *  https://github.com/chummer5a/chummer5a
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Chummer.Backend.Skills
{
    public class KnowledgeSkill : Skill
    {
        private static readonly Dictionary<string, string> s_CategoriesSkillMap = new Dictionary<string, string>();  //Categories to their attribute
        private static string s_strDefaultKnowledgeSkillsLanguage;
        private static List<ListItem> s_lstDefaultKnowledgeSkills;
        private static string s_strKnowledgeTypesLanguage;
        private static List<ListItem> s_lstKnowledgeTypes;

        public static IReadOnlyList<ListItem> DefaultKnowledgeSkills
        {
            get
            {
                if (s_lstDefaultKnowledgeSkills == null || !string.Equals(s_strDefaultKnowledgeSkillsLanguage, GlobalOptions.Language))
                {
                    s_lstDefaultKnowledgeSkills = DefaultKnowledgeSkillsForLanguage(GlobalOptions.Language).ToList();
                    s_lstDefaultKnowledgeSkills.Sort(CompareListItems.CompareNames);
                    s_strDefaultKnowledgeSkillsLanguage = GlobalOptions.Language;
                }
                return s_lstDefaultKnowledgeSkills;
            }
        }

        public static IEnumerable<ListItem> DefaultKnowledgeSkillsForLanguage(string strLanguage = "")
        {
            using (XmlNodeList xmlSkillList = XmlManager.Load("skills.xml", strLanguage).SelectNodes("/chummer/knowledgeskills/skill"))
            {
                if (xmlSkillList != null)
                {
                    foreach (XmlNode xmlSkill in xmlSkillList)
                    {
                        string strName = xmlSkill["name"]?.InnerText ?? string.Empty;
                        yield return new ListItem(strName, xmlSkill["translate"]?.InnerText ?? strName);
                    }
                }
            }
        }

        public static IReadOnlyList<ListItem> KnowledgeTypes
        {
            get
            {
                if (s_lstKnowledgeTypes == null || !string.Equals(s_strKnowledgeTypesLanguage, GlobalOptions.Language))
                {
                    s_lstKnowledgeTypes = KnowledgeTypesForLanguage(GlobalOptions.Language).ToList();
                    s_lstKnowledgeTypes.Sort(CompareListItems.CompareNames);
                    s_strKnowledgeTypesLanguage = GlobalOptions.Language;
                }
                return s_lstKnowledgeTypes;
            }
        }

        /// <summary>
        /// Load the (possible translated) types of kno skills (Academic, Street...)
        /// </summary>
        /// <param name="strLanguage"></param>
        /// <returns></returns>
        public static IEnumerable<ListItem> KnowledgeTypesForLanguage(string strLanguage = "")
        {
            using (XmlNodeList xmlCategoryList = XmlManager.Load("skills.xml", strLanguage).SelectNodes("/chummer/categories/category[@type = \"knowledge\"]"))
            {
                if (xmlCategoryList != null)
                {
                    foreach (XmlNode objXmlCategory in xmlCategoryList)
                    {
                        string strInnerText = objXmlCategory.InnerText;
                        yield return new ListItem(strInnerText, objXmlCategory.Attributes?["translate"]?.InnerText ?? strInnerText);
                    }
                }
            }
        }

        static KnowledgeSkill()
        {
            using (XmlNodeList xmlSkillList = XmlManager.Load("skills.xml").SelectNodes("/chummer/knowledgeskills/skill"))
            {
                if (xmlSkillList != null)
                {
                    foreach (XmlNode objXmlSkill in xmlSkillList)
                    {
                        string strCategory = objXmlSkill["category"]?.InnerText;
                        if (!string.IsNullOrWhiteSpace(strCategory))
                        {
                            s_CategoriesSkillMap[strCategory] = objXmlSkill["attribute"]?.InnerText;
                        }
                    }
                }
            }
        }

        public override bool IsKnowledgeSkill => true;

        public override bool AllowDelete => (!ForcedName || FreeBase + FreeKarma + RatingModifiers(Attribute) == 0) && !IsNativeLanguage;

        public override bool AllowNameChange => !ForcedName && (AllowUpgrade || IsNativeLanguage) && (!CharacterObject.Created || (Karma == 0 && Base == 0 && !IsNativeLanguage));

        public override bool AllowTypeChange => (AllowNameChange || string.IsNullOrWhiteSpace(Type)) && !IsNativeLanguage;

        private string _strType = string.Empty;

        private bool _blnIsNativeLanguage;

        public bool ForcedName { get; }

        public KnowledgeSkill(Character objCharacter) : base(objCharacter)
        {
            if (objCharacter == null)
                throw new ArgumentNullException(nameof(objCharacter));
            AttributeObject = objCharacter.LOG;
        }

        public KnowledgeSkill(Character objCharacter, string strForcedName, bool allowUpgrade) : this(objCharacter)
        {
            WriteableName = strForcedName;
            ForcedName = true;
            _blnAllowUpgrade = allowUpgrade;
        }

        private bool _blnAllowUpgrade = true;

        /// <summary>
        /// Is the skill allowed to be upgraded through karma or points?
        /// </summary>
        public bool AllowUpgrade
        {
            get
            {
                if (IsNativeLanguage)
                    return false;
                return _blnAllowUpgrade;
            }
            set => _blnAllowUpgrade = value;
        }

        public string WriteableName
        {
            get => CurrentDisplayName;
            set
            {
                if (ForcedName)
                {
                    return;
                }

                if (string.Equals(CurrentDisplayName, value, StringComparison.CurrentCulture))
                {
                    return;
                }

                LoadSkillFromData(value);
                Name = value;
                OnPropertyChanged();
            }
        }

        private void LoadSkillFromData(string strInputSkillName)
        {
            string strSkillName = GetSkillNameFromData(strInputSkillName);
            XmlNode xmlSkillNode = XmlManager.Load("skills.xml").SelectSingleNode("/chummer/knowledgeskills/skill[name = \"" + strSkillName + "\"]");

            if (xmlSkillNode == null)
            {
                SkillId = Guid.Empty;
                return;
            }

            SkillId = xmlSkillNode.TryGetField("id", Guid.TryParse, out Guid guidTemp)
                ? guidTemp
                : Guid.Empty;

            string strCategory = xmlSkillNode["category"]?.InnerText;

            if (!string.IsNullOrEmpty(strCategory))
            {
                Type = strCategory;
            }

            string strAttribute = xmlSkillNode["attribute"]?.InnerText;

            if (!string.IsNullOrEmpty(strAttribute))
            {
                AttributeObject = CharacterObject.GetAttribute(strAttribute) ?? CharacterObject.LOG;
            }
        }

        private static string GetSkillNameFromData(string strInputSkillName)
        {
            if (GlobalOptions.Language == GlobalOptions.DefaultLanguage)
            {
                return strInputSkillName;
            }

            XmlNode xmlSkillTranslationNode = XmlManager.Load("skills.xml").SelectSingleNode("/chummer/knowledgeskills/skill[translate = \"" + strInputSkillName + "\"]");

            if (xmlSkillTranslationNode == null)
            {
                return LanguageManager.ReverseTranslateExtra(strInputSkillName);
            }

            return xmlSkillTranslationNode["name"]?.InnerText ?? strInputSkillName;
        }

        public override string SkillCategory => Type;

        public override string DisplayPool
        {
            get
            {
                if (IsNativeLanguage)
                    return LanguageManager.GetString("Skill_NativeLanguageShort");
                return base.DisplayPool;
            }
        }

        /// <summary>
        /// The attributeValue this skill have from Skilljacks + Knowsoft
        /// </summary>
        /// <returns>Artificial skill attributeValue</returns>
        public override int CyberwareRating
        {
            get
            {
                if (_intCachedCyberwareRating != int.MinValue)
                    return _intCachedCyberwareRating;

                string strTranslatedName = CurrentDisplayName;
                int intMaxHardwire = CharacterObject.Improvements
                    .Where(objImprovement => objImprovement.ImproveType == Improvement.ImprovementType.Hardwire &&
                                            (objImprovement.ImprovedName == Name || objImprovement.ImprovedName == strTranslatedName) &&
                                             objImprovement.Enabled)
                    .Select(objImprovement => decimal.ToInt32(decimal.Ceiling(objImprovement.Value))).Concat((-1).Yield()).Max();
                if (intMaxHardwire >= 0)
                {
                    return _intCachedCyberwareRating = intMaxHardwire;
                }

                int intMaxSkillsoftRating = decimal.ToInt32(decimal.Ceiling(ImprovementManager.ValueOf(CharacterObject, Improvement.ImprovementType.SkillsoftAccess)));
                if (intMaxSkillsoftRating <= 0) return _intCachedCyberwareRating = 0;
                int intMax = CharacterObject.Improvements
                    .Where(objSkillsoftImprovement => objSkillsoftImprovement.ImproveType == Improvement.ImprovementType.Skillsoft &&
                                                      objSkillsoftImprovement.ImprovedName == InternalId && objSkillsoftImprovement.Enabled)
                    .Select(objSkillsoftImprovement => decimal.ToInt32(decimal.Ceiling(objSkillsoftImprovement.Value))).Concat(0.Yield()).Max();

                return _intCachedCyberwareRating = Math.Min(intMax, intMaxSkillsoftRating);

            }
        }

        public string Type
        {
            get => _strType;
            set
            {
                if (value == _strType) return;
                _strType = value;

                //2018-22-03: Causes any attempt to alter the Type for skills with names that match
                //default skills to reset to the default Type for that skill. If we want to disable
                //that behavior, better to disable it via the control.
                /*
                if (!LoadSkill())
                {
                    if (s_CategoriesSkillMap.TryGetValue(value, out string strNewAttributeValue))
                    {
                        AttributeObject = CharacterObject.GetAttribute(strNewAttributeValue);
                    }
                }
                */
                if (s_CategoriesSkillMap.TryGetValue(value, out string strNewAttributeValue))
                {
                    AttributeObject = CharacterObject.GetAttribute(strNewAttributeValue);
                }

                OnPropertyChanged();
                if (!IsLanguage)
                    IsNativeLanguage = false;
            }
        }

        public override bool IsLanguage => Type == "Language";

        public override bool IsNativeLanguage
        {
            get => _blnIsNativeLanguage;
            set
            {
                if (_blnIsNativeLanguage != value)
                {
                    _blnIsNativeLanguage = value;
                    if (value)
                    {
                        Base = 0;
                        Karma = 0;
                        BuyWithKarma = false;
                        Specializations.Clear();
                    }
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// How much karma this costs. Return value during career mode is undefined
        /// </summary>
        /// <returns></returns>
        public override int CurrentKarmaCost
        {
            get
            {
                int intTotalBaseRating = TotalBaseRating;
                decimal decCost = intTotalBaseRating * (intTotalBaseRating + 1);
                int intLower = Base + FreeKarma + RatingModifiers(Attribute);
                decCost -= intLower * (intLower + 1);

                decCost /= 2;
                decCost *= CharacterObject.Options.KarmaImproveKnowledgeSkill;
                // We have bought the first level with karma, too
                if (intLower == 0 && decCost > 0)
                    decCost += CharacterObject.Options.KarmaNewKnowledgeSkill - CharacterObject.Options.KarmaImproveKnowledgeSkill;

                decimal decMultiplier = 1.0m;
                decimal decExtra = 0;
                int intSpecCount = 0;
                foreach (SkillSpecialization objSpec in Specializations)
                {
                    if (!objSpec.Free && BuyWithKarma)
                        intSpecCount += 1;
                }
                decimal decSpecCost = CharacterObject.Options.KarmaKnowledgeSpecialization * intSpecCount;
                decimal decExtraSpecCost = 0;
                decimal decSpecCostMultiplier = 1.0m;
                foreach (Improvement objLoopImprovement in CharacterObject.Improvements)
                {
                    if (objLoopImprovement.Minimum <= intTotalBaseRating &&
                        (string.IsNullOrEmpty(objLoopImprovement.Condition) || (objLoopImprovement.Condition == "career") == CharacterObject.Created || (objLoopImprovement.Condition == "create") != CharacterObject.Created) && objLoopImprovement.Enabled)
                    {
                        if (objLoopImprovement.ImprovedName == Name || string.IsNullOrEmpty(objLoopImprovement.ImprovedName))
                        {
                            if (objLoopImprovement.ImproveType == Improvement.ImprovementType.KnowledgeSkillKarmaCost)
                                decExtra += objLoopImprovement.Value * (Math.Min(intTotalBaseRating, objLoopImprovement.Maximum == 0 ? int.MaxValue : objLoopImprovement.Maximum) - Math.Max(intLower, objLoopImprovement.Minimum - 1));
                            else if (objLoopImprovement.ImproveType == Improvement.ImprovementType.KnowledgeSkillKarmaCostMultiplier)
                                decMultiplier *= objLoopImprovement.Value / 100.0m;
                        }
                        else if (objLoopImprovement.ImprovedName == SkillCategory)
                        {
                            if (objLoopImprovement.ImproveType == Improvement.ImprovementType.SkillCategoryKarmaCost)
                                decExtra += objLoopImprovement.Value * (Math.Min(intTotalBaseRating, objLoopImprovement.Maximum == 0 ? int.MaxValue : objLoopImprovement.Maximum) - Math.Max(intLower, objLoopImprovement.Minimum - 1));
                            else if (objLoopImprovement.ImproveType == Improvement.ImprovementType.SkillCategoryKarmaCostMultiplier)
                                decMultiplier *= objLoopImprovement.Value / 100.0m;
                            else if (objLoopImprovement.ImproveType == Improvement.ImprovementType.SkillCategorySpecializationKarmaCost)
                                decExtraSpecCost += objLoopImprovement.Value * intSpecCount;
                            else if (objLoopImprovement.ImproveType == Improvement.ImprovementType.SkillCategorySpecializationKarmaCostMultiplier)
                                decSpecCostMultiplier *= objLoopImprovement.Value / 100.0m;
                        }
                    }
                }
                if (decMultiplier != 1.0m)
                    decCost *= decMultiplier;

                if (decSpecCostMultiplier != 1.0m)
                    decSpecCost *= decSpecCostMultiplier;
                decCost += decExtra;
                decCost += decSpecCost + decExtraSpecCost; //Spec

                return Math.Max(decimal.ToInt32(decimal.Ceiling(decCost)), 0);
            }
        }

        /// <summary>
        /// Karma price to upgrade. Returns negative if impossible. Minimum value is always 1.
        /// </summary>
        /// <returns>Price in karma</returns>
        public override int UpgradeKarmaCost
        {
            get
            {
                int intTotalBaseRating = TotalBaseRating;
                if (intTotalBaseRating >= RatingMaximum)
                {
                    return -1;
                }
                int intOptionsCost;
                int intValue;
                if (intTotalBaseRating == 0)
                {
                    intOptionsCost = CharacterObject.Options.KarmaNewKnowledgeSkill;
                    intValue = intOptionsCost;
                }
                else
                {
                    intOptionsCost = CharacterObject.Options.KarmaNewKnowledgeSkill;
                    intValue = (intTotalBaseRating + 1) * intOptionsCost;
                }

                decimal decMultiplier = 1.0m;
                decimal decExtra = 0;
                int intMinOverride = int.MaxValue;
                foreach (Improvement objLoopImprovement in CharacterObject.Improvements)
                {
                    if ((objLoopImprovement.Maximum == 0 || intTotalBaseRating + 1 <= objLoopImprovement.Maximum) && objLoopImprovement.Minimum <= intTotalBaseRating + 1 &&
                        (string.IsNullOrEmpty(objLoopImprovement.Condition) || (objLoopImprovement.Condition == "career") == CharacterObject.Created || (objLoopImprovement.Condition == "create") != CharacterObject.Created) && objLoopImprovement.Enabled)
                    {
                        if (objLoopImprovement.ImprovedName == Name || string.IsNullOrWhiteSpace(objLoopImprovement.ImprovedName))
                        {
                            if (objLoopImprovement.ImproveType == Improvement.ImprovementType.KnowledgeSkillKarmaCost)
                                decExtra += objLoopImprovement.Value;
                            else if (objLoopImprovement.ImproveType == Improvement.ImprovementType.KnowledgeSkillKarmaCostMultiplier)
                                decMultiplier *= objLoopImprovement.Value / 100.0m;
                        }
                        else if (objLoopImprovement.ImprovedName == SkillCategory)
                        {
                            if (objLoopImprovement.ImproveType == Improvement.ImprovementType.SkillCategoryKarmaCost)
                                decExtra += objLoopImprovement.Value;
                            else if (objLoopImprovement.ImproveType == Improvement.ImprovementType.SkillCategoryKarmaCostMultiplier)
                                decMultiplier *= objLoopImprovement.Value / 100.0m;
                        }

                        if ((objLoopImprovement.ImprovedName == Name ||
                            string.IsNullOrWhiteSpace(objLoopImprovement.ImprovedName) ||
                            objLoopImprovement.ImprovedName == SkillCategory) && objLoopImprovement.ImproveType ==
                            Improvement.ImprovementType.KnowledgeSkillKarmaCostMinimum)
                        {
                            intMinOverride = Math.Min(intMinOverride, decimal.ToInt32(decimal.Ceiling(objLoopImprovement.Value)));
                        }
                    }
                }
                if (decMultiplier != 1.0m)
                    intValue = decimal.ToInt32(decimal.Ceiling(intValue * decMultiplier + decExtra));
                else
                    intValue += decimal.ToInt32(decimal.Ceiling(decExtra));
                if (intMinOverride != int.MaxValue)
                {
                    return Math.Max(intValue, intMinOverride);
                }
                return Math.Max(intValue, Math.Min(1, intOptionsCost));
            }
        }

        /// <summary>
        /// How much Sp this costs. Price during career mode is undefined
        /// </summary>
        /// <returns></returns>
        public override int CurrentSpCost
        {
            get
            {
                int intPointCost = BasePoints + (string.IsNullOrWhiteSpace(Specialization) || BuyWithKarma ? 0 : 1);

                decimal decExtra = 0;
                decimal decMultiplier = 1.0m;
                foreach (Improvement objLoopImprovement in CharacterObject.Improvements)
                {
                    if (objLoopImprovement.Minimum <= BasePoints &&
                        (string.IsNullOrEmpty(objLoopImprovement.Condition) || (objLoopImprovement.Condition == "career") == CharacterObject.Created || (objLoopImprovement.Condition == "create") != CharacterObject.Created) && objLoopImprovement.Enabled)
                    {
                        if (objLoopImprovement.ImprovedName == Name || string.IsNullOrEmpty(objLoopImprovement.ImprovedName))
                        {
                            if (objLoopImprovement.ImproveType == Improvement.ImprovementType.KnowledgeSkillPointCost)
                                decExtra += objLoopImprovement.Value * (Math.Min(BasePoints, objLoopImprovement.Maximum == 0 ? int.MaxValue : objLoopImprovement.Maximum) - objLoopImprovement.Minimum);
                            else if (objLoopImprovement.ImproveType == Improvement.ImprovementType.KnowledgeSkillPointCostMultiplier)
                                decMultiplier *= objLoopImprovement.Value / 100.0m;
                        }
                        else if (objLoopImprovement.ImprovedName == SkillCategory)
                        {
                            if (objLoopImprovement.ImproveType == Improvement.ImprovementType.SkillCategoryPointCost)
                                decExtra += objLoopImprovement.Value * (Math.Min(BasePoints, objLoopImprovement.Maximum == 0 ? int.MaxValue : objLoopImprovement.Maximum) - objLoopImprovement.Minimum);
                            else if (objLoopImprovement.ImproveType == Improvement.ImprovementType.SkillCategoryPointCostMultiplier)
                                decMultiplier *= objLoopImprovement.Value / 100.0m;
                        }
                    }
                }
                if (decMultiplier != 1.0m)
                    intPointCost = decimal.ToInt32(decimal.Ceiling(intPointCost * decMultiplier + decExtra));
                else
                    intPointCost += decimal.ToInt32(decimal.Ceiling(decExtra));

                return Math.Max(intPointCost, 0);
            }
        }

        public override void WriteTo(XmlTextWriter objWriter)
        {
            if (objWriter == null)
                return;
            objWriter.WriteStartElement("skill");
            objWriter.WriteElementString("guid", Id.ToString("D", GlobalOptions.InvariantCultureInfo));
            objWriter.WriteElementString("suid", SkillId.ToString("D", GlobalOptions.InvariantCultureInfo));
            objWriter.WriteElementString("isknowledge", bool.TrueString);
            objWriter.WriteElementString("skillcategory", SkillCategory);
            objWriter.WriteElementString("karma", KarmaPoints.ToString(GlobalOptions.InvariantCultureInfo));
            objWriter.WriteElementString("base", BasePoints.ToString(GlobalOptions.InvariantCultureInfo)); //this could actually be saved in karma too during career
            objWriter.WriteElementString("notes", Notes);
            if (!CharacterObject.Created)
            {
                objWriter.WriteElementString("buywithkarma", BuyWithKarma.ToString(GlobalOptions.InvariantCultureInfo));
            }

            if (Specializations.Count != 0)
            {
                objWriter.WriteStartElement("specs");
                foreach (SkillSpecialization objSpecialization in Specializations)
                {
                    objSpecialization.Save(objWriter);
                }
                objWriter.WriteEndElement();
            }

            objWriter.WriteElementString("name", Name);
            objWriter.WriteElementString("type", _strType);
            objWriter.WriteElementString("isnativelanguage", _blnIsNativeLanguage.ToString(GlobalOptions.InvariantCultureInfo));
            if (ForcedName)
                objWriter.WriteElementString("forced", null);

            objWriter.WriteEndElement();

        }

        public void Load(XmlNode xmlNode)
        {
            if (xmlNode == null)
                return;
            string strTemp = Name;
            if (xmlNode.TryGetStringFieldQuickly("name", ref strTemp))
                Name = strTemp;
            if (xmlNode.TryGetField("id", Guid.TryParse, out Guid guiTemp))
                SkillId = guiTemp;
            else if (xmlNode.TryGetField("suid", Guid.TryParse, out Guid guiTemp2))
                SkillId = guiTemp2;

            // Legacy shim
            if (SkillId.Equals(Guid.Empty))
            {
                XmlNode objDataNode = XmlManager.Load("skills.xml").SelectSingleNode("/chummer/knowledgeskills/skill[name = \"" + Name + "\"]");
                if (objDataNode.TryGetField("id", Guid.TryParse, out Guid guidTemp))
                    SkillId = guidTemp;
            }

            string strCategoryString = string.Empty;
            if ((xmlNode.TryGetStringFieldQuickly("type", ref strCategoryString) && !string.IsNullOrEmpty(strCategoryString))
                || (xmlNode.TryGetStringFieldQuickly("skillcategory", ref strCategoryString) && !string.IsNullOrEmpty(strCategoryString)))
            {
                Type = strCategoryString;
            }

            // Legacy sweep for native language skills
            if (!xmlNode.TryGetBoolFieldQuickly("isnativelanguage", ref _blnIsNativeLanguage) && IsLanguage && CharacterObject.LastSavedVersion <= new Version(5, 212, 72))
            {
                int intKarma = 0;
                int intBase = 0;
                xmlNode.TryGetInt32FieldQuickly("karma", ref intKarma);
                xmlNode.TryGetInt32FieldQuickly("base", ref intBase);
                if (intKarma == 0 && intBase == 0 && CharacterObject.SkillsSection.KnowledgeSkills.Count(x => x.IsNativeLanguage) < 1 + ImprovementManager.ValueOf(CharacterObject, Improvement.ImprovementType.NativeLanguageLimit))
                    _blnIsNativeLanguage = true;
            }
        }
    }
}
