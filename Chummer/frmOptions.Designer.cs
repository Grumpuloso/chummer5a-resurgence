namespace Chummer
{
    partial class frmOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.tlpOptions = new Chummer.BufferedTableLayoutPanel(this.components);
            this.txtSettingName = new System.Windows.Forms.TextBox();
            this.lblSetting = new System.Windows.Forms.Label();
            this.lblSettingName = new System.Windows.Forms.Label();
            this.cboSetting = new Chummer.ElasticComboBox();
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tabGlobal = new System.Windows.Forms.TabPage();
            this.tlpGlobal = new Chummer.BufferedTableLayoutPanel(this.components);
            this.grpSelectedSourcebook = new System.Windows.Forms.GroupBox();
            this.tlpSelectedSourcebook = new Chummer.BufferedTableLayoutPanel(this.components);
            this.txtPDFLocation = new System.Windows.Forms.TextBox();
            this.lblPDFLocation = new System.Windows.Forms.Label();
            this.cmdPDFLocation = new System.Windows.Forms.Button();
            this.lblPDFOffset = new System.Windows.Forms.Label();
            this.flpPDFOffset = new System.Windows.Forms.FlowLayoutPanel();
            this.nudPDFOffset = new Chummer.NumericUpDownEx();
            this.cmdPDFTest = new System.Windows.Forms.Button();
            this.tlpGlobalOptions = new System.Windows.Forms.TableLayoutPanel();
            this.lblPDFAppPath = new System.Windows.Forms.Label();
            this.lblPDFParametersLabel = new System.Windows.Forms.Label();
            this.grpTimeFormat = new System.Windows.Forms.GroupBox();
            this.bufferedTableLayoutPanel3 = new Chummer.BufferedTableLayoutPanel(this.components);
            this.txtTimeFormat = new System.Windows.Forms.TextBox();
            this.txtTimeFormatView = new System.Windows.Forms.TextBox();
            this.chkSearchInCategoryOnly = new Chummer.ColorableCheckBox(this.components);
            this.lblCharacterRosterLabel = new System.Windows.Forms.Label();
            this.chkAllowEasterEggs = new Chummer.ColorableCheckBox(this.components);
            this.grpCharacterDefaults = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new Chummer.BufferedTableLayoutPanel(this.components);
            this.cboBuildMethod = new Chummer.ElasticComboBox();
            this.cboDefaultGameplayOption = new System.Windows.Forms.ComboBox();
            this.chkPrintToFileFirst = new Chummer.ColorableCheckBox(this.components);
            this.chkPreferNightlyBuilds = new Chummer.ColorableCheckBox(this.components);
            this.lblBrowserVersion = new System.Windows.Forms.Label();
            this.chkLiveUpdateCleanCharacterFiles = new Chummer.ColorableCheckBox(this.components);
            this.lblLanguage = new System.Windows.Forms.Label();
            this.chkDatesIncludeTime = new Chummer.ColorableCheckBox(this.components);
            this.chkLiveCustomData = new Chummer.ColorableCheckBox(this.components);
            this.chkSingleDiceRoller = new Chummer.ColorableCheckBox(this.components);
            this.chkStartupFullscreen = new Chummer.ColorableCheckBox(this.components);
            this.lblXSLT = new System.Windows.Forms.Label();
            this.imgLanguageFlag = new System.Windows.Forms.PictureBox();
            this.chkAutomaticUpdate = new Chummer.ColorableCheckBox(this.components);
            this.chkUseLogging = new Chummer.ColorableCheckBox(this.components);
            this.imgSheetLanguageFlag = new System.Windows.Forms.PictureBox();
            this.cboSheetLanguage = new Chummer.ElasticComboBox();
            this.cboLanguage = new Chummer.ElasticComboBox();
            this.cmdVerify = new System.Windows.Forms.Button();
            this.cmdVerifyData = new System.Windows.Forms.Button();
            this.cboXSLT = new Chummer.ElasticComboBox();
            this.chkCustomDateTimeFormats = new Chummer.ColorableCheckBox(this.components);
            this.chkConfirmKarmaExpense = new Chummer.ColorableCheckBox(this.components);
            this.chkConfirmDelete = new Chummer.ColorableCheckBox(this.components);
            this.flpUseLogging = new System.Windows.Forms.FlowLayoutPanel();
            this.cboUseLoggingApplicationInsights = new System.Windows.Forms.ComboBox();
            this.cmdUseLoggingHelp = new Chummer.ButtonWithToolTip();
            this.chkHideItemsOverAvail = new Chummer.ColorableCheckBox(this.components);
            this.flpEnablePlugins = new System.Windows.Forms.FlowLayoutPanel();
            this.chkEnablePlugins = new Chummer.ColorableCheckBox(this.components);
            this.cmdPluginsHelp = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCharacterRosterPath = new System.Windows.Forms.TextBox();
            this.cmdCharacterRoster = new System.Windows.Forms.Button();
            this.cboPDFParameters = new Chummer.ElasticComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPDFAppPath = new System.Windows.Forms.TextBox();
            this.cmdPDFAppPath = new System.Windows.Forms.Button();
            this.grpDateFormat = new System.Windows.Forms.GroupBox();
            this.bufferedTableLayoutPanel2 = new Chummer.BufferedTableLayoutPanel(this.components);
            this.txtDateFormat = new System.Windows.Forms.TextBox();
            this.txtDateFormatView = new System.Windows.Forms.TextBox();
            this.lblMugshotCompression = new System.Windows.Forms.Label();
            this.nudBrowserVersion = new Chummer.NumericUpDownEx();
            this.cboMugshotCompression = new Chummer.ElasticComboBox();
            this.flpMugshotCompressionQuality = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMugshotCompressionQuality = new System.Windows.Forms.Label();
            this.nudMugshotCompressionQuality = new Chummer.NumericUpDownEx();
            this.chkCreateBackupOnCareer = new Chummer.ColorableCheckBox(this.components);
            this.chkHideCharacterRoster = new Chummer.ColorableCheckBox(this.components);
            this.chkHideMasterIndex = new Chummer.ColorableCheckBox(this.components);
            this.chkAllowHoverIncrement = new Chummer.ColorableCheckBox(this.components);
            this.chkLifeModule = new Chummer.ColorableCheckBox(this.components);
            this.tlpColorMode = new System.Windows.Forms.TableLayoutPanel();
            this.cboColorMode = new System.Windows.Forms.ComboBox();
            this.lblColorMode = new System.Windows.Forms.Label();
            this.gpbEditSourcebookInfo = new System.Windows.Forms.GroupBox();
            this.lstGlobalSourcebookInfos = new System.Windows.Forms.ListBox();
            this.tabCharacterOptions = new System.Windows.Forms.TabPage();
            this.tlpCharacterOptions = new Chummer.BufferedTableLayoutPanel(this.components);
            this.chkPrintExpenses = new Chummer.ColorableCheckBox(this.components);
            this.chkPrintSkillsWithZeroRating = new Chummer.ColorableCheckBox(this.components);
            this.chkDontUseCyberlimbCalculation = new Chummer.ColorableCheckBox(this.components);
            this.chkAllowSkillDiceRolling = new Chummer.ColorableCheckBox(this.components);
            this.chkEnforceCapacity = new Chummer.ColorableCheckBox(this.components);
            this.chkLicenseEachRestrictedItem = new Chummer.ColorableCheckBox(this.components);
            this.lblEssenceDecimals = new System.Windows.Forms.Label();
            this.lblNuyenDecimalsMaximumLabel = new System.Windows.Forms.Label();
            this.lblNuyenDecimalsMinimumLabel = new System.Windows.Forms.Label();
            this.chkDontRoundEssenceInternally = new Chummer.ColorableCheckBox(this.components);
            this.chkDronemods = new Chummer.ColorableCheckBox(this.components);
            this.chkRestrictRecoil = new Chummer.ColorableCheckBox(this.components);
            this.nudNuyenDecimalsMinimum = new Chummer.NumericUpDownEx();
            this.nudNuyenDecimalsMaximum = new Chummer.NumericUpDownEx();
            this.nudEssenceDecimals = new Chummer.NumericUpDownEx();
            this.chkDronemodsMaximumPilot = new Chummer.ColorableCheckBox(this.components);
            this.chkPrintFreeExpenses = new Chummer.ColorableCheckBox(this.components);
            this.lblLimbCount = new System.Windows.Forms.Label();
            this.cboLimbCount = new Chummer.ElasticComboBox();
            this.cmdEnableSourcebooks = new System.Windows.Forms.Button();
            this.gpbSourcebook = new System.Windows.Forms.GroupBox();
            this.treSourcebook = new System.Windows.Forms.TreeView();
            this.chkPrintNotes = new Chummer.ColorableCheckBox(this.components);
            this.tabKarmaCosts = new System.Windows.Forms.TabPage();
            this.tlpKarmaCosts = new System.Windows.Forms.TableLayoutPanel();
            this.cmdRestoreDefaultsKarma = new System.Windows.Forms.Button();
            this.tlpKarmaCostsList = new Chummer.BufferedTableLayoutPanel(this.components);
            this.lblKarmaNuyenPerExtra = new System.Windows.Forms.Label();
            this.nudKarmaNuyenPer = new Chummer.NumericUpDownEx();
            this.lblKarmaNuyenPer = new System.Windows.Forms.Label();
            this.lblKarmaImproveKnowledgeSkill = new System.Windows.Forms.Label();
            this.nudKarmaImproveKnowledgeSkill = new Chummer.NumericUpDownEx();
            this.lblKarmaImproveKnowledgeSkillExtra = new System.Windows.Forms.Label();
            this.lblKarmaImproveActiveSkill = new System.Windows.Forms.Label();
            this.nudKarmaImproveActiveSkill = new Chummer.NumericUpDownEx();
            this.lblKarmaImproveActiveSkillExtra = new System.Windows.Forms.Label();
            this.lblKarmaImproveSkillGroup = new System.Windows.Forms.Label();
            this.nudKarmaImproveSkillGroup = new Chummer.NumericUpDownEx();
            this.lblKarmaImproveSkillGroupExtra = new System.Windows.Forms.Label();
            this.lblKarmaAttribute = new System.Windows.Forms.Label();
            this.nudKarmaAttribute = new Chummer.NumericUpDownEx();
            this.lblKarmaAttributeExtra = new System.Windows.Forms.Label();
            this.lblKarmaQuality = new System.Windows.Forms.Label();
            this.nudKarmaQuality = new Chummer.NumericUpDownEx();
            this.lblKarmaQualityExtra = new System.Windows.Forms.Label();
            this.lblKarmaAlchemicalFocusExtra = new System.Windows.Forms.Label();
            this.nudKarmaAlchemicalFocus = new Chummer.NumericUpDownEx();
            this.lblKarmaAlchemicalFocus = new System.Windows.Forms.Label();
            this.lblKarmaBanishingFocus = new System.Windows.Forms.Label();
            this.nudKarmaBanishingFocus = new Chummer.NumericUpDownEx();
            this.lblKarmaBanishingFocusExtra = new System.Windows.Forms.Label();
            this.lblKarmaBindingFocus = new System.Windows.Forms.Label();
            this.nudKarmaBindingFocus = new Chummer.NumericUpDownEx();
            this.lblKarmaBindingFocusExtra = new System.Windows.Forms.Label();
            this.lblKarmaCenteringFocus = new System.Windows.Forms.Label();
            this.nudKarmaCenteringFocus = new Chummer.NumericUpDownEx();
            this.lblKarmaCenteringFocusExtra = new System.Windows.Forms.Label();
            this.lblKarmaCounterspellingFocus = new System.Windows.Forms.Label();
            this.nudKarmaCounterspellingFocus = new Chummer.NumericUpDownEx();
            this.lblKarmaCounterspellingFocusExtra = new System.Windows.Forms.Label();
            this.lblKarmaDisenchantingFocus = new System.Windows.Forms.Label();
            this.nudKarmaDisenchantingFocus = new Chummer.NumericUpDownEx();
            this.lblKarmaDisenchantingFocusExtra = new System.Windows.Forms.Label();
            this.lblKarmaFlexibleSignatureFocus = new System.Windows.Forms.Label();
            this.nudKarmaFlexibleSignatureFocus = new Chummer.NumericUpDownEx();
            this.lblFlexibleSignatureFocusExtra = new System.Windows.Forms.Label();
            this.lblKarmaMaskingFocus = new System.Windows.Forms.Label();
            this.nudKarmaMaskingFocus = new Chummer.NumericUpDownEx();
            this.lblKarmaMaskingFocusExtra = new System.Windows.Forms.Label();
            this.lblKarmaPowerFocus = new System.Windows.Forms.Label();
            this.nudKarmaPowerFocus = new Chummer.NumericUpDownEx();
            this.lblKarmaPowerFocusExtra = new System.Windows.Forms.Label();
            this.lblKarmaQiFocus = new System.Windows.Forms.Label();
            this.nudKarmaQiFocus = new Chummer.NumericUpDownEx();
            this.lblKarmaQiFocusExtra = new System.Windows.Forms.Label();
            this.lblKarmaRitualSpellcastingFocus = new System.Windows.Forms.Label();
            this.nudKarmaRitualSpellcastingFocus = new Chummer.NumericUpDownEx();
            this.lblKarmaRitualSpellcastingFocusExtra = new System.Windows.Forms.Label();
            this.lblKarmaSpellcastingFocus = new System.Windows.Forms.Label();
            this.nudKarmaSpellcastingFocus = new Chummer.NumericUpDownEx();
            this.lblKarmaSpellcastingFocusExtra = new System.Windows.Forms.Label();
            this.lblKarmaSummoningFocus = new System.Windows.Forms.Label();
            this.nudKarmaSummoningFocus = new Chummer.NumericUpDownEx();
            this.lblKarmaSummoningFocusExtra = new System.Windows.Forms.Label();
            this.lblKarmaSustainingFocus = new System.Windows.Forms.Label();
            this.nudKarmaSustainingFocus = new Chummer.NumericUpDownEx();
            this.lblKarmaSustainingFocusExtra = new System.Windows.Forms.Label();
            this.lblKarmaSpellShapingFocus = new System.Windows.Forms.Label();
            this.lblKarmaSpellShapingFocusExtra = new System.Windows.Forms.Label();
            this.nudKarmaSpellShapingFocus = new Chummer.NumericUpDownEx();
            this.lblKarmaWeaponFocus = new System.Windows.Forms.Label();
            this.lblKarmaWeaponFocusExtra = new System.Windows.Forms.Label();
            this.nudKarmaWeaponFocus = new Chummer.NumericUpDownEx();
            this.lblMetatypeCostsKarmaMultiplierLabel = new System.Windows.Forms.Label();
            this.lblKarmaNewAIAdvancedProgram = new System.Windows.Forms.Label();
            this.lblKarmaNewAIProgram = new System.Windows.Forms.Label();
            this.lblKarmaTechnique = new System.Windows.Forms.Label();
            this.lblKarmaNewComplexForm = new System.Windows.Forms.Label();
            this.lblKarmaSpell = new System.Windows.Forms.Label();
            this.lblKarmaLeaveGroup = new System.Windows.Forms.Label();
            this.lblKarmaJoinGroup = new System.Windows.Forms.Label();
            this.lblKarmaMetamagic = new System.Windows.Forms.Label();
            this.nudMetatypeCostsKarmaMultiplier = new Chummer.NumericUpDownEx();
            this.nudKarmaNewAIAdvancedProgram = new Chummer.NumericUpDownEx();
            this.nudKarmaNewAIProgram = new Chummer.NumericUpDownEx();
            this.nudKarmaTechnique = new Chummer.NumericUpDownEx();
            this.nudKarmaNewComplexForm = new Chummer.NumericUpDownEx();
            this.nudKarmaSpell = new Chummer.NumericUpDownEx();
            this.nudKarmaLeaveGroup = new Chummer.NumericUpDownEx();
            this.nudKarmaJoinGroup = new Chummer.NumericUpDownEx();
            this.nudKarmaMetamagic = new Chummer.NumericUpDownEx();
            this.nudKarmaSpecialization = new Chummer.NumericUpDownEx();
            this.nudKarmaKnowledgeSpecialization = new Chummer.NumericUpDownEx();
            this.nudKarmaNewKnowledgeSkill = new Chummer.NumericUpDownEx();
            this.nudKarmaNewActiveSkill = new Chummer.NumericUpDownEx();
            this.nudKarmaNewSkillGroup = new Chummer.NumericUpDownEx();
            this.lblKarmaSpecialization = new System.Windows.Forms.Label();
            this.lblKarmaKnowledgeSpecialization = new System.Windows.Forms.Label();
            this.lblKarmaNewKnowledgeSkill = new System.Windows.Forms.Label();
            this.lblKarmaNewActiveSkill = new System.Windows.Forms.Label();
            this.lblKarmaNewSkillGroup = new System.Windows.Forms.Label();
            this.lblKarmaContact = new System.Windows.Forms.Label();
            this.nudKarmaContact = new Chummer.NumericUpDownEx();
            this.lblKarmaContactExtra = new System.Windows.Forms.Label();
            this.lblKarmaEnemy = new System.Windows.Forms.Label();
            this.nudKarmaEnemy = new Chummer.NumericUpDownEx();
            this.lblKarmaEnemyExtra = new System.Windows.Forms.Label();
            this.lblNuyenPerBP = new System.Windows.Forms.Label();
            this.nudNuyenPerBP = new Chummer.NumericUpDownEx();
            this.lblKarmaCarryover = new System.Windows.Forms.Label();
            this.nudKarmaCarryover = new Chummer.NumericUpDownEx();
            this.lblKarmaCarryoverExtra = new System.Windows.Forms.Label();
            this.flpKarmaInitiation = new System.Windows.Forms.FlowLayoutPanel();
            this.lblKarmaInitiation = new System.Windows.Forms.Label();
            this.lblKarmaInitiationBracket = new System.Windows.Forms.Label();
            this.nudKarmaInitiation = new Chummer.NumericUpDownEx();
            this.flpKarmaInitiationExtra = new System.Windows.Forms.FlowLayoutPanel();
            this.lblKarmaInitiationExtra = new System.Windows.Forms.Label();
            this.nudKarmaInitiationFlat = new Chummer.NumericUpDownEx();
            this.lblKarmaSpirit = new System.Windows.Forms.Label();
            this.nudKarmaSpirit = new Chummer.NumericUpDownEx();
            this.lblKarmaSpiritExtra = new System.Windows.Forms.Label();
            this.lblKarmaMysticAdeptPowerPoint = new System.Windows.Forms.Label();
            this.nudKarmaMysticAdeptPowerPoint = new Chummer.NumericUpDownEx();
            this.tabOptionalRules = new System.Windows.Forms.TabPage();
            this.tlpOptionalRules = new Chummer.BufferedTableLayoutPanel(this.components);
            this.cmdDecreaseCustomDirectoryLoadOrder = new System.Windows.Forms.Button();
            this.cmdIncreaseCustomDirectoryLoadOrder = new System.Windows.Forms.Button();
            this.lblCustomDataDirectoriesLabel = new System.Windows.Forms.Label();
            this.cmdAddCustomDirectory = new System.Windows.Forms.Button();
            this.treCustomDataDirectories = new System.Windows.Forms.TreeView();
            this.cmdRenameCustomDataDirectory = new System.Windows.Forms.Button();
            this.cmdRemoveCustomDirectory = new System.Windows.Forms.Button();
            this.tabHouseRules = new System.Windows.Forms.TabPage();
            this.tlpHouseRules = new Chummer.BufferedTableLayoutPanel(this.components);
            this.chkIgnoreArt = new Chummer.ColorableCheckBox(this.components);
            this.chkExceedNegativeQualitiesLimit = new Chummer.ColorableCheckBox(this.components);
            this.chkUseTotalValueForFreeKnowledge = new Chummer.ColorableCheckBox(this.components);
            this.chkExceedNegativeQualities = new Chummer.ColorableCheckBox(this.components);
            this.chkExceedPositiveQualitiesCostDoubled = new Chummer.ColorableCheckBox(this.components);
            this.chkExceedPositiveQualities = new Chummer.ColorableCheckBox(this.components);
            this.chkUnarmedSkillImprovements = new Chummer.ColorableCheckBox(this.components);
            this.chkCyberlegMovement = new Chummer.ColorableCheckBox(this.components);
            this.chkMysAdeptSecondMAGAttribute = new Chummer.ColorableCheckBox(this.components);
            this.chkDontDoubleQualityPurchases = new Chummer.ColorableCheckBox(this.components);
            this.chkAllowPointBuySpecializationsOnKarmaSkills = new Chummer.ColorableCheckBox(this.components);
            this.chkDontDoubleQualityRefunds = new Chummer.ColorableCheckBox(this.components);
            this.chkReverseAttributePriorityOrder = new Chummer.ColorableCheckBox(this.components);
            this.chkStrictSkillGroups = new Chummer.ColorableCheckBox(this.components);
            this.chkPrioritySpellsAsAdeptPowers = new Chummer.ColorableCheckBox(this.components);
            this.chkAllowInitiation = new Chummer.ColorableCheckBox(this.components);
            this.chkFreeMartialArtSpecialization = new Chummer.ColorableCheckBox(this.components);
            this.chkAllowCyberwareESSDiscounts = new Chummer.ColorableCheckBox(this.components);
            this.chkMysAdPp = new Chummer.ColorableCheckBox(this.components);
            this.chkESSLossReducesMaximumOnly = new Chummer.ColorableCheckBox(this.components);
            this.chkAlternateMetatypeAttributeKarma = new Chummer.ColorableCheckBox(this.components);
            this.chkUseCalculatedPublicAwareness = new Chummer.ColorableCheckBox(this.components);
            this.chkUseTotalValueForFreeContacts = new Chummer.ColorableCheckBox(this.components);
            this.chkIgnoreComplexFormLimit = new Chummer.ColorableCheckBox(this.components);
            this.chkSpecialKarmaCost = new Chummer.ColorableCheckBox(this.components);
            this.chkMoreLethalGameplay = new Chummer.ColorableCheckBox(this.components);
            this.chkExtendAnyDetectionSpell = new Chummer.ColorableCheckBox(this.components);
            this.chkAllowSkillRegrouping = new Chummer.ColorableCheckBox(this.components);
            this.chkNoArmorEncumbrance = new Chummer.ColorableCheckBox(this.components);
            this.chkIncreasedImprovedAbilityModifier = new Chummer.ColorableCheckBox(this.components);
            this.chkAllowFreeGrids = new Chummer.ColorableCheckBox(this.components);
            this.chkAllowTechnomancerSchooling = new Chummer.ColorableCheckBox(this.components);
            this.chkUsePointsOnBrokenGroups = new Chummer.ColorableCheckBox(this.components);
            this.flpDroneArmorMultiplier = new System.Windows.Forms.FlowLayoutPanel();
            this.chkDroneArmorMultiplier = new Chummer.ColorableCheckBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.nudDroneArmorMultiplier = new Chummer.NumericUpDownEx();
            this.flpContactMultiplier = new System.Windows.Forms.FlowLayoutPanel();
            this.chkContactMultiplier = new Chummer.ColorableCheckBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.nudContactMultiplier = new Chummer.NumericUpDownEx();
            this.flpKnowledgeMultiplier = new System.Windows.Forms.FlowLayoutPanel();
            this.chkKnowledgeMultiplier = new Chummer.ColorableCheckBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.nudKnowledgeMultiplier = new Chummer.NumericUpDownEx();
            this.flpCyberlimbAttributeBonusCap = new System.Windows.Forms.FlowLayoutPanel();
            this.chkCyberlimbAttributeBonusCap = new Chummer.ColorableCheckBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nudCyberlimbAttributeBonusCap = new Chummer.NumericUpDownEx();
            this.chkUnclampAttributeMinimum = new Chummer.ColorableCheckBox(this.components);
            this.chkEnemyKarmaQualityLimit = new Chummer.ColorableCheckBox(this.components);
            this.chkCompensateSkillGroupKarmaDifference = new Chummer.ColorableCheckBox(this.components);
            this.tabGitHubIssues = new System.Windows.Forms.TabPage();
            this.cmdUploadPastebin = new System.Windows.Forms.Button();
            this.tabPlugins = new System.Windows.Forms.TabPage();
            this.tlpPlugins = new Chummer.BufferedTableLayoutPanel(this.components);
            this.grpAvailablePlugins = new System.Windows.Forms.GroupBox();
            this.clbPlugins = new System.Windows.Forms.CheckedListBox();
            this.panelPluginOption = new System.Windows.Forms.Panel();
            this.flpOKCancel = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.tlpOptions.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.tabGlobal.SuspendLayout();
            this.tlpGlobal.SuspendLayout();
            this.grpSelectedSourcebook.SuspendLayout();
            this.tlpSelectedSourcebook.SuspendLayout();
            this.flpPDFOffset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPDFOffset)).BeginInit();
            this.tlpGlobalOptions.SuspendLayout();
            this.grpTimeFormat.SuspendLayout();
            this.bufferedTableLayoutPanel3.SuspendLayout();
            this.grpCharacterDefaults.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLanguageFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSheetLanguageFlag)).BeginInit();
            this.flpUseLogging.SuspendLayout();
            this.flpEnablePlugins.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.grpDateFormat.SuspendLayout();
            this.bufferedTableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrowserVersion)).BeginInit();
            this.flpMugshotCompressionQuality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMugshotCompressionQuality)).BeginInit();
            this.tlpColorMode.SuspendLayout();
            this.gpbEditSourcebookInfo.SuspendLayout();
            this.tabCharacterOptions.SuspendLayout();
            this.tlpCharacterOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNuyenDecimalsMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNuyenDecimalsMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEssenceDecimals)).BeginInit();
            this.gpbSourcebook.SuspendLayout();
            this.tabKarmaCosts.SuspendLayout();
            this.tlpKarmaCosts.SuspendLayout();
            this.tlpKarmaCostsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaNuyenPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaImproveKnowledgeSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaImproveActiveSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaImproveSkillGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaAttribute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaAlchemicalFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaBanishingFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaBindingFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaCenteringFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaCounterspellingFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaDisenchantingFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaFlexibleSignatureFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaMaskingFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaPowerFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaQiFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaRitualSpellcastingFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaSpellcastingFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaSummoningFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaSustainingFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaSpellShapingFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaWeaponFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMetatypeCostsKarmaMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaNewAIAdvancedProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaNewAIProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaTechnique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaNewComplexForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaSpell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaLeaveGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaJoinGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaMetamagic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaSpecialization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaKnowledgeSpecialization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaNewKnowledgeSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaNewActiveSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaNewSkillGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNuyenPerBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaCarryover)).BeginInit();
            this.flpKarmaInitiation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaInitiation)).BeginInit();
            this.flpKarmaInitiationExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaInitiationFlat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaSpirit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaMysticAdeptPowerPoint)).BeginInit();
            this.tabOptionalRules.SuspendLayout();
            this.tlpOptionalRules.SuspendLayout();
            this.tabHouseRules.SuspendLayout();
            this.tlpHouseRules.SuspendLayout();
            this.flpDroneArmorMultiplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDroneArmorMultiplier)).BeginInit();
            this.flpContactMultiplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContactMultiplier)).BeginInit();
            this.flpKnowledgeMultiplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKnowledgeMultiplier)).BeginInit();
            this.flpCyberlimbAttributeBonusCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCyberlimbAttributeBonusCap)).BeginInit();
            this.tabGitHubIssues.SuspendLayout();
            this.tabPlugins.SuspendLayout();
            this.tlpPlugins.SuspendLayout();
            this.grpAvailablePlugins.SuspendLayout();
            this.flpOKCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpOptions
            // 
            this.tlpOptions.AutoSize = true;
            this.tlpOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOptions.ColumnCount = 4;
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOptions.Controls.Add(this.txtSettingName, 3, 0);
            this.tlpOptions.Controls.Add(this.lblSetting, 0, 0);
            this.tlpOptions.Controls.Add(this.lblSettingName, 2, 0);
            this.tlpOptions.Controls.Add(this.cboSetting, 1, 0);
            this.tlpOptions.Controls.Add(this.tabOptions, 0, 1);
            this.tlpOptions.Controls.Add(this.flpOKCancel, 0, 2);
            this.tlpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptions.Location = new System.Drawing.Point(9, 9);
            this.tlpOptions.Name = "tlpOptions";
            this.tlpOptions.RowCount = 3;
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.Size = new System.Drawing.Size(1246, 663);
            this.tlpOptions.TabIndex = 7;
            // 
            // txtSettingName
            // 
            this.txtSettingName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSettingName.Location = new System.Drawing.Point(702, 3);
            this.txtSettingName.Name = "txtSettingName";
            this.txtSettingName.Size = new System.Drawing.Size(541, 20);
            this.txtSettingName.TabIndex = 3;
            this.txtSettingName.TextChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblSetting
            // 
            this.lblSetting.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSetting.AutoSize = true;
            this.lblSetting.Location = new System.Drawing.Point(3, 7);
            this.lblSetting.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(67, 13);
            this.lblSetting.TabIndex = 0;
            this.lblSetting.Tag = "Label_Options_SettingsFile";
            this.lblSetting.Text = "Settings File:";
            // 
            // lblSettingName
            // 
            this.lblSettingName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSettingName.AutoSize = true;
            this.lblSettingName.Location = new System.Drawing.Point(622, 7);
            this.lblSettingName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSettingName.Name = "lblSettingName";
            this.lblSettingName.Size = new System.Drawing.Size(74, 13);
            this.lblSettingName.TabIndex = 2;
            this.lblSettingName.Tag = "Label_Options_SettingName";
            this.lblSettingName.Text = "Setting Name:";
            // 
            // cboSetting
            // 
            this.cboSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSetting.FormattingEnabled = true;
            this.cboSetting.Location = new System.Drawing.Point(76, 3);
            this.cboSetting.Name = "cboSetting";
            this.cboSetting.Size = new System.Drawing.Size(540, 21);
            this.cboSetting.TabIndex = 1;
            this.cboSetting.TooltipText = "";
            this.cboSetting.SelectedIndexChanged += new System.EventHandler(this.cboSetting_SelectedIndexChanged);
            // 
            // tabOptions
            // 
            this.tlpOptions.SetColumnSpan(this.tabOptions, 4);
            this.tabOptions.Controls.Add(this.tabGlobal);
            this.tabOptions.Controls.Add(this.tabCharacterOptions);
            this.tabOptions.Controls.Add(this.tabKarmaCosts);
            this.tabOptions.Controls.Add(this.tabOptionalRules);
            this.tabOptions.Controls.Add(this.tabHouseRules);
            this.tabOptions.Controls.Add(this.tabGitHubIssues);
            this.tabOptions.Controls.Add(this.tabPlugins);
            this.tabOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOptions.Location = new System.Drawing.Point(3, 30);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(1240, 594);
            this.tabOptions.TabIndex = 4;
            // 
            // tabGlobal
            // 
            this.tabGlobal.BackColor = System.Drawing.SystemColors.Control;
            this.tabGlobal.Controls.Add(this.tlpGlobal);
            this.tabGlobal.Location = new System.Drawing.Point(4, 22);
            this.tabGlobal.Name = "tabGlobal";
            this.tabGlobal.Padding = new System.Windows.Forms.Padding(9);
            this.tabGlobal.Size = new System.Drawing.Size(1232, 568);
            this.tabGlobal.TabIndex = 5;
            this.tabGlobal.Tag = "Tab_Options_Global";
            this.tabGlobal.Text = "Global Options";
            // 
            // tlpGlobal
            // 
            this.tlpGlobal.AutoSize = true;
            this.tlpGlobal.ColumnCount = 2;
            this.tlpGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGlobal.Controls.Add(this.grpSelectedSourcebook, 1, 1);
            this.tlpGlobal.Controls.Add(this.tlpGlobalOptions, 1, 0);
            this.tlpGlobal.Controls.Add(this.gpbEditSourcebookInfo, 0, 0);
            this.tlpGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGlobal.Location = new System.Drawing.Point(9, 9);
            this.tlpGlobal.Name = "tlpGlobal";
            this.tlpGlobal.RowCount = 2;
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.Size = new System.Drawing.Size(1214, 550);
            this.tlpGlobal.TabIndex = 39;
            // 
            // grpSelectedSourcebook
            // 
            this.grpSelectedSourcebook.AutoSize = true;
            this.grpSelectedSourcebook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpSelectedSourcebook.Controls.Add(this.tlpSelectedSourcebook);
            this.grpSelectedSourcebook.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpSelectedSourcebook.Enabled = false;
            this.grpSelectedSourcebook.Location = new System.Drawing.Point(304, 470);
            this.grpSelectedSourcebook.Name = "grpSelectedSourcebook";
            this.grpSelectedSourcebook.Size = new System.Drawing.Size(434, 77);
            this.grpSelectedSourcebook.TabIndex = 27;
            this.grpSelectedSourcebook.TabStop = false;
            this.grpSelectedSourcebook.Tag = "Label_Options_SelectedSourcebook";
            this.grpSelectedSourcebook.Text = "Selected Sourcebook:";
            // 
            // tlpSelectedSourcebook
            // 
            this.tlpSelectedSourcebook.AutoSize = true;
            this.tlpSelectedSourcebook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpSelectedSourcebook.ColumnCount = 3;
            this.tlpSelectedSourcebook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSelectedSourcebook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSelectedSourcebook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSelectedSourcebook.Controls.Add(this.txtPDFLocation, 1, 0);
            this.tlpSelectedSourcebook.Controls.Add(this.lblPDFLocation, 0, 0);
            this.tlpSelectedSourcebook.Controls.Add(this.cmdPDFLocation, 2, 0);
            this.tlpSelectedSourcebook.Controls.Add(this.lblPDFOffset, 0, 1);
            this.tlpSelectedSourcebook.Controls.Add(this.flpPDFOffset, 1, 1);
            this.tlpSelectedSourcebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSelectedSourcebook.Location = new System.Drawing.Point(3, 16);
            this.tlpSelectedSourcebook.Name = "tlpSelectedSourcebook";
            this.tlpSelectedSourcebook.RowCount = 2;
            this.tlpSelectedSourcebook.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSelectedSourcebook.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSelectedSourcebook.Size = new System.Drawing.Size(428, 58);
            this.tlpSelectedSourcebook.TabIndex = 18;
            // 
            // txtPDFLocation
            // 
            this.txtPDFLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPDFLocation.Location = new System.Drawing.Point(84, 4);
            this.txtPDFLocation.Name = "txtPDFLocation";
            this.txtPDFLocation.ReadOnly = true;
            this.txtPDFLocation.Size = new System.Drawing.Size(309, 20);
            this.txtPDFLocation.TabIndex = 13;
            this.txtPDFLocation.TextChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblPDFLocation
            // 
            this.lblPDFLocation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPDFLocation.AutoSize = true;
            this.lblPDFLocation.Location = new System.Drawing.Point(3, 8);
            this.lblPDFLocation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPDFLocation.Name = "lblPDFLocation";
            this.lblPDFLocation.Size = new System.Drawing.Size(75, 13);
            this.lblPDFLocation.TabIndex = 12;
            this.lblPDFLocation.Tag = "Label_Options_PDFLocation";
            this.lblPDFLocation.Text = "PDF Location:";
            this.lblPDFLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdPDFLocation
            // 
            this.cmdPDFLocation.AutoSize = true;
            this.cmdPDFLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdPDFLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdPDFLocation.Location = new System.Drawing.Point(399, 3);
            this.cmdPDFLocation.Name = "cmdPDFLocation";
            this.cmdPDFLocation.Size = new System.Drawing.Size(26, 23);
            this.cmdPDFLocation.TabIndex = 14;
            this.cmdPDFLocation.Text = "...";
            this.cmdPDFLocation.UseVisualStyleBackColor = true;
            this.cmdPDFLocation.Click += new System.EventHandler(this.cmdPDFLocation_Click);
            // 
            // lblPDFOffset
            // 
            this.lblPDFOffset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPDFOffset.AutoSize = true;
            this.lblPDFOffset.Location = new System.Drawing.Point(12, 37);
            this.lblPDFOffset.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPDFOffset.Name = "lblPDFOffset";
            this.lblPDFOffset.Size = new System.Drawing.Size(66, 13);
            this.lblPDFOffset.TabIndex = 15;
            this.lblPDFOffset.Tag = "Label_Options_PDFOffset";
            this.lblPDFOffset.Text = "Page Offset:";
            this.lblPDFOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flpPDFOffset
            // 
            this.flpPDFOffset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flpPDFOffset.AutoSize = true;
            this.flpPDFOffset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpSelectedSourcebook.SetColumnSpan(this.flpPDFOffset, 2);
            this.flpPDFOffset.Controls.Add(this.nudPDFOffset);
            this.flpPDFOffset.Controls.Add(this.cmdPDFTest);
            this.flpPDFOffset.Location = new System.Drawing.Point(81, 29);
            this.flpPDFOffset.Margin = new System.Windows.Forms.Padding(0);
            this.flpPDFOffset.Name = "flpPDFOffset";
            this.flpPDFOffset.Size = new System.Drawing.Size(175, 29);
            this.flpPDFOffset.TabIndex = 16;
            this.flpPDFOffset.WrapContents = false;
            // 
            // nudPDFOffset
            // 
            this.nudPDFOffset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudPDFOffset.AutoSize = true;
            this.nudPDFOffset.Location = new System.Drawing.Point(3, 4);
            this.nudPDFOffset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudPDFOffset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudPDFOffset.Name = "nudPDFOffset";
            this.nudPDFOffset.Size = new System.Drawing.Size(41, 20);
            this.nudPDFOffset.TabIndex = 16;
            this.nudPDFOffset.ValueChanged += new System.EventHandler(this.nudPDFOffset_ValueChanged);
            // 
            // cmdPDFTest
            // 
            this.cmdPDFTest.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmdPDFTest.AutoSize = true;
            this.cmdPDFTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdPDFTest.Location = new System.Drawing.Point(50, 3);
            this.cmdPDFTest.Name = "cmdPDFTest";
            this.cmdPDFTest.Size = new System.Drawing.Size(122, 23);
            this.cmdPDFTest.TabIndex = 17;
            this.cmdPDFTest.Tag = "Button_Options_PDFTest";
            this.cmdPDFTest.Text = "Test - Open to Page 5";
            this.cmdPDFTest.UseVisualStyleBackColor = true;
            this.cmdPDFTest.Click += new System.EventHandler(this.cmdPDFTest_Click);
            // 
            // tlpGlobalOptions
            // 
            this.tlpGlobalOptions.AutoScroll = true;
            this.tlpGlobalOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGlobalOptions.ColumnCount = 6;
            this.tlpGlobalOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpGlobalOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpGlobalOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpGlobalOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpGlobalOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpGlobalOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpGlobalOptions.Controls.Add(this.lblPDFAppPath, 0, 21);
            this.tlpGlobalOptions.Controls.Add(this.lblPDFParametersLabel, 0, 20);
            this.tlpGlobalOptions.Controls.Add(this.grpTimeFormat, 4, 2);
            this.tlpGlobalOptions.Controls.Add(this.chkSearchInCategoryOnly, 3, 10);
            this.tlpGlobalOptions.Controls.Add(this.lblCharacterRosterLabel, 0, 19);
            this.tlpGlobalOptions.Controls.Add(this.chkAllowEasterEggs, 0, 6);
            this.tlpGlobalOptions.Controls.Add(this.grpCharacterDefaults, 3, 14);
            this.tlpGlobalOptions.Controls.Add(this.chkPrintToFileFirst, 0, 16);
            this.tlpGlobalOptions.Controls.Add(this.chkPreferNightlyBuilds, 0, 14);
            this.tlpGlobalOptions.Controls.Add(this.lblBrowserVersion, 0, 17);
            this.tlpGlobalOptions.Controls.Add(this.chkLiveUpdateCleanCharacterFiles, 0, 13);
            this.tlpGlobalOptions.Controls.Add(this.lblLanguage, 0, 0);
            this.tlpGlobalOptions.Controls.Add(this.chkDatesIncludeTime, 0, 10);
            this.tlpGlobalOptions.Controls.Add(this.chkLiveCustomData, 0, 7);
            this.tlpGlobalOptions.Controls.Add(this.chkSingleDiceRoller, 0, 9);
            this.tlpGlobalOptions.Controls.Add(this.chkStartupFullscreen, 0, 8);
            this.tlpGlobalOptions.Controls.Add(this.lblXSLT, 0, 1);
            this.tlpGlobalOptions.Controls.Add(this.imgLanguageFlag, 1, 0);
            this.tlpGlobalOptions.Controls.Add(this.chkAutomaticUpdate, 0, 5);
            this.tlpGlobalOptions.Controls.Add(this.chkUseLogging, 0, 4);
            this.tlpGlobalOptions.Controls.Add(this.imgSheetLanguageFlag, 1, 1);
            this.tlpGlobalOptions.Controls.Add(this.cboSheetLanguage, 2, 1);
            this.tlpGlobalOptions.Controls.Add(this.cboLanguage, 2, 0);
            this.tlpGlobalOptions.Controls.Add(this.cmdVerify, 4, 0);
            this.tlpGlobalOptions.Controls.Add(this.cmdVerifyData, 5, 0);
            this.tlpGlobalOptions.Controls.Add(this.cboXSLT, 4, 1);
            this.tlpGlobalOptions.Controls.Add(this.chkCustomDateTimeFormats, 0, 2);
            this.tlpGlobalOptions.Controls.Add(this.chkConfirmKarmaExpense, 3, 4);
            this.tlpGlobalOptions.Controls.Add(this.chkConfirmDelete, 3, 3);
            this.tlpGlobalOptions.Controls.Add(this.flpUseLogging, 1, 4);
            this.tlpGlobalOptions.Controls.Add(this.chkHideItemsOverAvail, 3, 5);
            this.tlpGlobalOptions.Controls.Add(this.flpEnablePlugins, 3, 6);
            this.tlpGlobalOptions.Controls.Add(this.flowLayoutPanel2, 2, 19);
            this.tlpGlobalOptions.Controls.Add(this.cboPDFParameters, 2, 20);
            this.tlpGlobalOptions.Controls.Add(this.flowLayoutPanel3, 2, 21);
            this.tlpGlobalOptions.Controls.Add(this.grpDateFormat, 2, 2);
            this.tlpGlobalOptions.Controls.Add(this.lblMugshotCompression, 0, 18);
            this.tlpGlobalOptions.Controls.Add(this.nudBrowserVersion, 2, 17);
            this.tlpGlobalOptions.Controls.Add(this.cboMugshotCompression, 2, 18);
            this.tlpGlobalOptions.Controls.Add(this.flpMugshotCompressionQuality, 3, 18);
            this.tlpGlobalOptions.Controls.Add(this.chkCreateBackupOnCareer, 0, 15);
            this.tlpGlobalOptions.Controls.Add(this.chkHideCharacterRoster, 3, 12);
            this.tlpGlobalOptions.Controls.Add(this.chkHideMasterIndex, 3, 11);
            this.tlpGlobalOptions.Controls.Add(this.chkAllowHoverIncrement, 3, 9);
            this.tlpGlobalOptions.Controls.Add(this.chkLifeModule, 3, 8);
            this.tlpGlobalOptions.Controls.Add(this.tlpColorMode, 0, 3);
            this.tlpGlobalOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGlobalOptions.Location = new System.Drawing.Point(301, 0);
            this.tlpGlobalOptions.Margin = new System.Windows.Forms.Padding(0);
            this.tlpGlobalOptions.Name = "tlpGlobalOptions";
            this.tlpGlobalOptions.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tlpGlobalOptions.RowCount = 23;
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobalOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tlpGlobalOptions.Size = new System.Drawing.Size(913, 467);
            this.tlpGlobalOptions.TabIndex = 67;
            // 
            // lblPDFAppPath
            // 
            this.lblPDFAppPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPDFAppPath.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.lblPDFAppPath, 2);
            this.lblPDFAppPath.Location = new System.Drawing.Point(52, 604);
            this.lblPDFAppPath.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPDFAppPath.Name = "lblPDFAppPath";
            this.lblPDFAppPath.Size = new System.Drawing.Size(141, 13);
            this.lblPDFAppPath.TabIndex = 9;
            this.lblPDFAppPath.Tag = "Label_Options_PDFApplicationPath";
            this.lblPDFAppPath.Text = "Location of PDF application:";
            // 
            // lblPDFParametersLabel
            // 
            this.lblPDFParametersLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPDFParametersLabel.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.lblPDFParametersLabel, 2);
            this.lblPDFParametersLabel.Location = new System.Drawing.Point(106, 576);
            this.lblPDFParametersLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPDFParametersLabel.Name = "lblPDFParametersLabel";
            this.lblPDFParametersLabel.Size = new System.Drawing.Size(87, 13);
            this.lblPDFParametersLabel.TabIndex = 19;
            this.lblPDFParametersLabel.Tag = "Label_Options_PDFParameters";
            this.lblPDFParametersLabel.Text = "PDF Parameters:";
            // 
            // grpTimeFormat
            // 
            this.grpTimeFormat.AutoSize = true;
            this.grpTimeFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGlobalOptions.SetColumnSpan(this.grpTimeFormat, 2);
            this.grpTimeFormat.Controls.Add(this.bufferedTableLayoutPanel3);
            this.grpTimeFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTimeFormat.Enabled = false;
            this.grpTimeFormat.Location = new System.Drawing.Point(544, 56);
            this.grpTimeFormat.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.grpTimeFormat.Name = "grpTimeFormat";
            this.grpTimeFormat.Size = new System.Drawing.Size(339, 71);
            this.grpTimeFormat.TabIndex = 61;
            this.grpTimeFormat.TabStop = false;
            this.grpTimeFormat.Tag = "Label_Options_TimeFormat";
            this.grpTimeFormat.Text = "Time Format";
            // 
            // bufferedTableLayoutPanel3
            // 
            this.bufferedTableLayoutPanel3.AutoSize = true;
            this.bufferedTableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bufferedTableLayoutPanel3.ColumnCount = 1;
            this.bufferedTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bufferedTableLayoutPanel3.Controls.Add(this.txtTimeFormat, 0, 1);
            this.bufferedTableLayoutPanel3.Controls.Add(this.txtTimeFormatView, 0, 0);
            this.bufferedTableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bufferedTableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.bufferedTableLayoutPanel3.Name = "bufferedTableLayoutPanel3";
            this.bufferedTableLayoutPanel3.RowCount = 2;
            this.bufferedTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bufferedTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bufferedTableLayoutPanel3.Size = new System.Drawing.Size(333, 52);
            this.bufferedTableLayoutPanel3.TabIndex = 0;
            // 
            // txtTimeFormat
            // 
            this.txtTimeFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeFormat.Location = new System.Drawing.Point(3, 29);
            this.txtTimeFormat.Name = "txtTimeFormat";
            this.txtTimeFormat.Size = new System.Drawing.Size(327, 20);
            this.txtTimeFormat.TabIndex = 48;
            this.txtTimeFormat.TextChanged += new System.EventHandler(this.txtTimeFormat_TextChanged);
            // 
            // txtTimeFormatView
            // 
            this.txtTimeFormatView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeFormatView.Location = new System.Drawing.Point(3, 3);
            this.txtTimeFormatView.Name = "txtTimeFormatView";
            this.txtTimeFormatView.ReadOnly = true;
            this.txtTimeFormatView.Size = new System.Drawing.Size(327, 20);
            this.txtTimeFormatView.TabIndex = 47;
            // 
            // chkSearchInCategoryOnly
            // 
            this.chkSearchInCategoryOnly.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSearchInCategoryOnly.AutoSize = true;
            this.chkSearchInCategoryOnly.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkSearchInCategoryOnly.Checked = true;
            this.chkSearchInCategoryOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tlpGlobalOptions.SetColumnSpan(this.chkSearchInCategoryOnly, 3);
            this.chkSearchInCategoryOnly.DefaultColorScheme = true;
            this.chkSearchInCategoryOnly.Location = new System.Drawing.Point(406, 316);
            this.chkSearchInCategoryOnly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSearchInCategoryOnly.Name = "chkSearchInCategoryOnly";
            this.chkSearchInCategoryOnly.Size = new System.Drawing.Size(325, 17);
            this.chkSearchInCategoryOnly.TabIndex = 21;
            this.chkSearchInCategoryOnly.Tag = "Checkbox_Options_SearchInCategoryOnly";
            this.chkSearchInCategoryOnly.Text = "Searching in selection forms is restricted to the current Category";
            this.chkSearchInCategoryOnly.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkSearchInCategoryOnly.UseVisualStyleBackColor = true;
            this.chkSearchInCategoryOnly.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblCharacterRosterLabel
            // 
            this.lblCharacterRosterLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCharacterRosterLabel.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.lblCharacterRosterLabel, 2);
            this.lblCharacterRosterLabel.Location = new System.Drawing.Point(36, 548);
            this.lblCharacterRosterLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCharacterRosterLabel.Name = "lblCharacterRosterLabel";
            this.lblCharacterRosterLabel.Size = new System.Drawing.Size(157, 13);
            this.lblCharacterRosterLabel.TabIndex = 44;
            this.lblCharacterRosterLabel.Tag = "Label_Options_CharacterRoster";
            this.lblCharacterRosterLabel.Text = "Character Roster Watch Folder:";
            // 
            // chkAllowEasterEggs
            // 
            this.chkAllowEasterEggs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAllowEasterEggs.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkAllowEasterEggs, 3);
            this.chkAllowEasterEggs.DefaultColorScheme = true;
            this.chkAllowEasterEggs.Location = new System.Drawing.Point(3, 214);
            this.chkAllowEasterEggs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAllowEasterEggs.Name = "chkAllowEasterEggs";
            this.chkAllowEasterEggs.Size = new System.Drawing.Size(111, 17);
            this.chkAllowEasterEggs.TabIndex = 52;
            this.chkAllowEasterEggs.Tag = "Checkbox_Options_AllowEasterEggs";
            this.chkAllowEasterEggs.Text = "Allow Easter Eggs";
            this.chkAllowEasterEggs.UseVisualStyleBackColor = true;
            this.chkAllowEasterEggs.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // grpCharacterDefaults
            // 
            this.grpCharacterDefaults.AutoSize = true;
            this.grpCharacterDefaults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGlobalOptions.SetColumnSpan(this.grpCharacterDefaults, 3);
            this.grpCharacterDefaults.Controls.Add(this.tableLayoutPanel7);
            this.grpCharacterDefaults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCharacterDefaults.Location = new System.Drawing.Point(406, 412);
            this.grpCharacterDefaults.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.grpCharacterDefaults.Name = "grpCharacterDefaults";
            this.tlpGlobalOptions.SetRowSpan(this.grpCharacterDefaults, 3);
            this.grpCharacterDefaults.Size = new System.Drawing.Size(477, 75);
            this.grpCharacterDefaults.TabIndex = 42;
            this.grpCharacterDefaults.TabStop = false;
            this.grpCharacterDefaults.Tag = "Label_Options_Defaults";
            this.grpCharacterDefaults.Text = "Defaults for New Characters";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.cboBuildMethod, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.cboDefaultGameplayOption, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(471, 56);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // cboBuildMethod
            // 
            this.cboBuildMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboBuildMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuildMethod.FormattingEnabled = true;
            this.cboBuildMethod.Location = new System.Drawing.Point(3, 3);
            this.cboBuildMethod.Name = "cboBuildMethod";
            this.cboBuildMethod.Size = new System.Drawing.Size(465, 21);
            this.cboBuildMethod.TabIndex = 6;
            this.cboBuildMethod.TooltipText = "";
            this.cboBuildMethod.SelectedIndexChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // cboDefaultGameplayOption
            // 
            this.cboDefaultGameplayOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboDefaultGameplayOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDefaultGameplayOption.FormattingEnabled = true;
            this.cboDefaultGameplayOption.Location = new System.Drawing.Point(3, 30);
            this.cboDefaultGameplayOption.Name = "cboDefaultGameplayOption";
            this.cboDefaultGameplayOption.Size = new System.Drawing.Size(465, 21);
            this.cboDefaultGameplayOption.TabIndex = 7;
            this.cboDefaultGameplayOption.SelectedIndexChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkPrintToFileFirst
            // 
            this.chkPrintToFileFirst.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkPrintToFileFirst.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkPrintToFileFirst, 3);
            this.chkPrintToFileFirst.DefaultColorScheme = true;
            this.chkPrintToFileFirst.Location = new System.Drawing.Point(3, 466);
            this.chkPrintToFileFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkPrintToFileFirst.Name = "chkPrintToFileFirst";
            this.chkPrintToFileFirst.Size = new System.Drawing.Size(130, 17);
            this.chkPrintToFileFirst.TabIndex = 43;
            this.chkPrintToFileFirst.Tag = "Checkbox_Option_PrintToFileFirst";
            this.chkPrintToFileFirst.Text = "Apply Linux printing fix";
            this.chkPrintToFileFirst.UseVisualStyleBackColor = true;
            this.chkPrintToFileFirst.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkPreferNightlyBuilds
            // 
            this.chkPreferNightlyBuilds.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkPreferNightlyBuilds.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkPreferNightlyBuilds, 3);
            this.chkPreferNightlyBuilds.DefaultColorScheme = true;
            this.chkPreferNightlyBuilds.Location = new System.Drawing.Point(3, 416);
            this.chkPreferNightlyBuilds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkPreferNightlyBuilds.Name = "chkPreferNightlyBuilds";
            this.chkPreferNightlyBuilds.Size = new System.Drawing.Size(120, 17);
            this.chkPreferNightlyBuilds.TabIndex = 25;
            this.chkPreferNightlyBuilds.Tag = "Checkbox_Options_PreferNightlyBuilds";
            this.chkPreferNightlyBuilds.Text = "Prefer Nightly Builds";
            this.chkPreferNightlyBuilds.UseVisualStyleBackColor = true;
            this.chkPreferNightlyBuilds.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblBrowserVersion
            // 
            this.lblBrowserVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrowserVersion.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.lblBrowserVersion, 2);
            this.lblBrowserVersion.Location = new System.Drawing.Point(3, 493);
            this.lblBrowserVersion.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblBrowserVersion.Name = "lblBrowserVersion";
            this.lblBrowserVersion.Size = new System.Drawing.Size(190, 17);
            this.lblBrowserVersion.TabIndex = 53;
            this.lblBrowserVersion.Tag = "Label_Options_BrowserVersion";
            this.lblBrowserVersion.Text = "Preview uses Internet Explorer version:";
            // 
            // chkLiveUpdateCleanCharacterFiles
            // 
            this.chkLiveUpdateCleanCharacterFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkLiveUpdateCleanCharacterFiles.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkLiveUpdateCleanCharacterFiles, 6);
            this.chkLiveUpdateCleanCharacterFiles.DefaultColorScheme = true;
            this.chkLiveUpdateCleanCharacterFiles.Location = new System.Drawing.Point(3, 391);
            this.chkLiveUpdateCleanCharacterFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkLiveUpdateCleanCharacterFiles.Name = "chkLiveUpdateCleanCharacterFiles";
            this.chkLiveUpdateCleanCharacterFiles.Size = new System.Drawing.Size(519, 17);
            this.chkLiveUpdateCleanCharacterFiles.TabIndex = 33;
            this.chkLiveUpdateCleanCharacterFiles.Tag = "Checkbox_Options_LiveUpdateCleanCharacterFiles";
            this.chkLiveUpdateCleanCharacterFiles.Text = "Automatically load changes from open characters\' save files if there are no pendi" +
    "ng changes to be saved";
            this.chkLiveUpdateCleanCharacterFiles.UseVisualStyleBackColor = true;
            this.chkLiveUpdateCleanCharacterFiles.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(113, 8);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(58, 13);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Tag = "Label_Options_Language";
            this.lblLanguage.Text = "Language:";
            // 
            // chkDatesIncludeTime
            // 
            this.chkDatesIncludeTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkDatesIncludeTime.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkDatesIncludeTime, 3);
            this.chkDatesIncludeTime.DefaultColorScheme = true;
            this.chkDatesIncludeTime.Location = new System.Drawing.Point(3, 316);
            this.chkDatesIncludeTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDatesIncludeTime.Name = "chkDatesIncludeTime";
            this.chkDatesIncludeTime.Size = new System.Drawing.Size(189, 17);
            this.chkDatesIncludeTime.TabIndex = 9;
            this.chkDatesIncludeTime.Tag = "Checkbox_Options_DatesIncludeTime";
            this.chkDatesIncludeTime.Text = "Expense dates should include time";
            this.chkDatesIncludeTime.UseVisualStyleBackColor = true;
            this.chkDatesIncludeTime.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkLiveCustomData
            // 
            this.chkLiveCustomData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkLiveCustomData.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkLiveCustomData, 3);
            this.chkLiveCustomData.DefaultColorScheme = true;
            this.chkLiveCustomData.Location = new System.Drawing.Point(3, 241);
            this.chkLiveCustomData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkLiveCustomData.Name = "chkLiveCustomData";
            this.chkLiveCustomData.Size = new System.Drawing.Size(307, 17);
            this.chkLiveCustomData.TabIndex = 28;
            this.chkLiveCustomData.Tag = "Checkbox_Options_Live_CustomData";
            this.chkLiveCustomData.Text = "Allow Live Custom Data Updates from customdata Directory";
            this.chkLiveCustomData.UseVisualStyleBackColor = true;
            this.chkLiveCustomData.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkSingleDiceRoller
            // 
            this.chkSingleDiceRoller.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSingleDiceRoller.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkSingleDiceRoller, 3);
            this.chkSingleDiceRoller.DefaultColorScheme = true;
            this.chkSingleDiceRoller.Location = new System.Drawing.Point(3, 291);
            this.chkSingleDiceRoller.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSingleDiceRoller.Name = "chkSingleDiceRoller";
            this.chkSingleDiceRoller.Size = new System.Drawing.Size(251, 17);
            this.chkSingleDiceRoller.TabIndex = 8;
            this.chkSingleDiceRoller.Tag = "Checkbox_Options_SingleDiceRoller";
            this.chkSingleDiceRoller.Text = "Use a single instance of the Dice Roller window";
            this.chkSingleDiceRoller.UseVisualStyleBackColor = true;
            this.chkSingleDiceRoller.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkStartupFullscreen
            // 
            this.chkStartupFullscreen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkStartupFullscreen.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkStartupFullscreen, 3);
            this.chkStartupFullscreen.DefaultColorScheme = true;
            this.chkStartupFullscreen.Location = new System.Drawing.Point(3, 266);
            this.chkStartupFullscreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkStartupFullscreen.Name = "chkStartupFullscreen";
            this.chkStartupFullscreen.Size = new System.Drawing.Size(154, 17);
            this.chkStartupFullscreen.TabIndex = 7;
            this.chkStartupFullscreen.Tag = "Checkbox_Options_StartupFullscreen";
            this.chkStartupFullscreen.Text = "Start Chummer in fullscreen";
            this.chkStartupFullscreen.UseVisualStyleBackColor = true;
            this.chkStartupFullscreen.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblXSLT
            // 
            this.lblXSLT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblXSLT.AutoSize = true;
            this.lblXSLT.Location = new System.Drawing.Point(47, 36);
            this.lblXSLT.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblXSLT.Name = "lblXSLT";
            this.lblXSLT.Size = new System.Drawing.Size(124, 13);
            this.lblXSLT.TabIndex = 7;
            this.lblXSLT.Tag = "Label_Options_DefaultCharacterSheet";
            this.lblXSLT.Text = "Default Character Sheet:";
            // 
            // imgLanguageFlag
            // 
            this.imgLanguageFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLanguageFlag.Location = new System.Drawing.Point(177, 3);
            this.imgLanguageFlag.Name = "imgLanguageFlag";
            this.imgLanguageFlag.Size = new System.Drawing.Size(16, 23);
            this.imgLanguageFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLanguageFlag.TabIndex = 49;
            this.imgLanguageFlag.TabStop = false;
            // 
            // chkAutomaticUpdate
            // 
            this.chkAutomaticUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAutomaticUpdate.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkAutomaticUpdate, 3);
            this.chkAutomaticUpdate.DefaultColorScheme = true;
            this.chkAutomaticUpdate.Location = new System.Drawing.Point(3, 187);
            this.chkAutomaticUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAutomaticUpdate.Name = "chkAutomaticUpdate";
            this.chkAutomaticUpdate.Size = new System.Drawing.Size(116, 17);
            this.chkAutomaticUpdate.TabIndex = 5;
            this.chkAutomaticUpdate.Tag = "Checkbox_Options_AutomaticUpdates";
            this.chkAutomaticUpdate.Text = "Automatic Updates";
            this.chkAutomaticUpdate.UseVisualStyleBackColor = true;
            this.chkAutomaticUpdate.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkUseLogging
            // 
            this.chkUseLogging.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkUseLogging.AutoSize = true;
            this.chkUseLogging.DefaultColorScheme = true;
            this.chkUseLogging.Location = new System.Drawing.Point(3, 160);
            this.chkUseLogging.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkUseLogging.Name = "chkUseLogging";
            this.chkUseLogging.Size = new System.Drawing.Size(86, 17);
            this.chkUseLogging.TabIndex = 4;
            this.chkUseLogging.Tag = "Checkbox_Options_UseLogging";
            this.chkUseLogging.Text = "Use Logging";
            this.chkUseLogging.UseVisualStyleBackColor = true;
            this.chkUseLogging.CheckedChanged += new System.EventHandler(this.chkUseLogging_CheckedChanged);
            // 
            // imgSheetLanguageFlag
            // 
            this.imgSheetLanguageFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgSheetLanguageFlag.Location = new System.Drawing.Point(177, 32);
            this.imgSheetLanguageFlag.Name = "imgSheetLanguageFlag";
            this.imgSheetLanguageFlag.Size = new System.Drawing.Size(16, 21);
            this.imgSheetLanguageFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgSheetLanguageFlag.TabIndex = 50;
            this.imgSheetLanguageFlag.TabStop = false;
            // 
            // cboSheetLanguage
            // 
            this.cboSheetLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpGlobalOptions.SetColumnSpan(this.cboSheetLanguage, 2);
            this.cboSheetLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSheetLanguage.FormattingEnabled = true;
            this.cboSheetLanguage.Location = new System.Drawing.Point(199, 32);
            this.cboSheetLanguage.Name = "cboSheetLanguage";
            this.cboSheetLanguage.Size = new System.Drawing.Size(339, 21);
            this.cboSheetLanguage.TabIndex = 34;
            this.cboSheetLanguage.TooltipText = "";
            this.cboSheetLanguage.SelectedIndexChanged += new System.EventHandler(this.cboSheetLanguage_SelectedIndexChanged);
            // 
            // cboLanguage
            // 
            this.cboLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpGlobalOptions.SetColumnSpan(this.cboLanguage, 2);
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Location = new System.Drawing.Point(199, 4);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(339, 21);
            this.cboLanguage.TabIndex = 1;
            this.cboLanguage.TooltipText = "";
            this.cboLanguage.SelectedIndexChanged += new System.EventHandler(this.cboLanguage_SelectedIndexChanged);
            // 
            // cmdVerify
            // 
            this.cmdVerify.AutoSize = true;
            this.cmdVerify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdVerify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdVerify.Enabled = false;
            this.cmdVerify.Location = new System.Drawing.Point(544, 3);
            this.cmdVerify.Name = "cmdVerify";
            this.cmdVerify.Size = new System.Drawing.Size(166, 23);
            this.cmdVerify.TabIndex = 2;
            this.cmdVerify.Text = "Verify";
            this.cmdVerify.UseVisualStyleBackColor = true;
            this.cmdVerify.Click += new System.EventHandler(this.cmdVerify_Click);
            // 
            // cmdVerifyData
            // 
            this.cmdVerifyData.AutoSize = true;
            this.cmdVerifyData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdVerifyData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdVerifyData.Enabled = false;
            this.cmdVerifyData.Location = new System.Drawing.Point(716, 3);
            this.cmdVerifyData.Name = "cmdVerifyData";
            this.cmdVerifyData.Size = new System.Drawing.Size(167, 23);
            this.cmdVerifyData.TabIndex = 3;
            this.cmdVerifyData.Text = "Verify Data File";
            this.cmdVerifyData.UseVisualStyleBackColor = true;
            this.cmdVerifyData.Click += new System.EventHandler(this.cmdVerifyData_Click);
            // 
            // cboXSLT
            // 
            this.cboXSLT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpGlobalOptions.SetColumnSpan(this.cboXSLT, 2);
            this.cboXSLT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXSLT.FormattingEnabled = true;
            this.cboXSLT.Location = new System.Drawing.Point(544, 32);
            this.cboXSLT.Name = "cboXSLT";
            this.cboXSLT.Size = new System.Drawing.Size(339, 21);
            this.cboXSLT.TabIndex = 8;
            this.cboXSLT.TooltipText = "";
            // 
            // chkCustomDateTimeFormats
            // 
            this.chkCustomDateTimeFormats.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkCustomDateTimeFormats.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkCustomDateTimeFormats, 2);
            this.chkCustomDateTimeFormats.DefaultColorScheme = true;
            this.chkCustomDateTimeFormats.Location = new System.Drawing.Point(3, 83);
            this.chkCustomDateTimeFormats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCustomDateTimeFormats.Name = "chkCustomDateTimeFormats";
            this.chkCustomDateTimeFormats.Size = new System.Drawing.Size(122, 17);
            this.chkCustomDateTimeFormats.TabIndex = 60;
            this.chkCustomDateTimeFormats.Tag = "Checkbox_Options_CustomTimeFormat";
            this.chkCustomDateTimeFormats.Text = "Custom Time Format";
            this.chkCustomDateTimeFormats.UseVisualStyleBackColor = true;
            this.chkCustomDateTimeFormats.CheckedChanged += new System.EventHandler(this.chkCustomDateTimeFormats_CheckedChanged);
            // 
            // chkConfirmKarmaExpense
            // 
            this.chkConfirmKarmaExpense.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkConfirmKarmaExpense.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkConfirmKarmaExpense, 3);
            this.chkConfirmKarmaExpense.DefaultColorScheme = true;
            this.chkConfirmKarmaExpense.Location = new System.Drawing.Point(406, 160);
            this.chkConfirmKarmaExpense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkConfirmKarmaExpense.Name = "chkConfirmKarmaExpense";
            this.chkConfirmKarmaExpense.Size = new System.Drawing.Size(215, 17);
            this.chkConfirmKarmaExpense.TabIndex = 39;
            this.chkConfirmKarmaExpense.Tag = "Checkbox_Options_ConfirmKarmaExpense";
            this.chkConfirmKarmaExpense.Text = "Ask for confirmation for Karma expenses";
            this.chkConfirmKarmaExpense.UseVisualStyleBackColor = true;
            this.chkConfirmKarmaExpense.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkConfirmDelete
            // 
            this.chkConfirmDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkConfirmDelete.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkConfirmDelete, 3);
            this.chkConfirmDelete.DefaultColorScheme = true;
            this.chkConfirmDelete.Location = new System.Drawing.Point(406, 132);
            this.chkConfirmDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkConfirmDelete.Name = "chkConfirmDelete";
            this.chkConfirmDelete.Size = new System.Drawing.Size(215, 17);
            this.chkConfirmDelete.TabIndex = 38;
            this.chkConfirmDelete.Tag = "Checkbox_Options_ConfirmDelete";
            this.chkConfirmDelete.Text = "Ask for confirmation when deleting items";
            this.chkConfirmDelete.UseVisualStyleBackColor = true;
            this.chkConfirmDelete.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // flpUseLogging
            // 
            this.flpUseLogging.AutoSize = true;
            this.flpUseLogging.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGlobalOptions.SetColumnSpan(this.flpUseLogging, 2);
            this.flpUseLogging.Controls.Add(this.cboUseLoggingApplicationInsights);
            this.flpUseLogging.Controls.Add(this.cmdUseLoggingHelp);
            this.flpUseLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpUseLogging.Location = new System.Drawing.Point(174, 154);
            this.flpUseLogging.Margin = new System.Windows.Forms.Padding(0);
            this.flpUseLogging.Name = "flpUseLogging";
            this.flpUseLogging.Size = new System.Drawing.Size(229, 29);
            this.flpUseLogging.TabIndex = 62;
            this.flpUseLogging.WrapContents = false;
            // 
            // cboUseLoggingApplicationInsights
            // 
            this.cboUseLoggingApplicationInsights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUseLoggingApplicationInsights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUseLoggingApplicationInsights.Location = new System.Drawing.Point(3, 4);
            this.cboUseLoggingApplicationInsights.Name = "cboUseLoggingApplicationInsights";
            this.cboUseLoggingApplicationInsights.Size = new System.Drawing.Size(194, 21);
            this.cboUseLoggingApplicationInsights.TabIndex = 55;
            this.cboUseLoggingApplicationInsights.SelectedIndexChanged += new System.EventHandler(this.cboUseLoggingApplicationInsights_SelectedIndexChanged);
            // 
            // cmdUseLoggingHelp
            // 
            this.cmdUseLoggingHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmdUseLoggingHelp.AutoSize = true;
            this.cmdUseLoggingHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdUseLoggingHelp.Location = new System.Drawing.Point(203, 3);
            this.cmdUseLoggingHelp.Name = "cmdUseLoggingHelp";
            this.cmdUseLoggingHelp.Size = new System.Drawing.Size(23, 23);
            this.cmdUseLoggingHelp.TabIndex = 56;
            this.cmdUseLoggingHelp.Text = "?";
            this.cmdUseLoggingHelp.ToolTipText = "";
            this.cmdUseLoggingHelp.UseVisualStyleBackColor = true;
            this.cmdUseLoggingHelp.Click += new System.EventHandler(this.cboUseLoggingHelp_Click);
            // 
            // chkHideItemsOverAvail
            // 
            this.chkHideItemsOverAvail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkHideItemsOverAvail.AutoSize = true;
            this.chkHideItemsOverAvail.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkHideItemsOverAvail.Checked = true;
            this.chkHideItemsOverAvail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tlpGlobalOptions.SetColumnSpan(this.chkHideItemsOverAvail, 3);
            this.chkHideItemsOverAvail.DefaultColorScheme = true;
            this.chkHideItemsOverAvail.Location = new System.Drawing.Point(406, 187);
            this.chkHideItemsOverAvail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkHideItemsOverAvail.Name = "chkHideItemsOverAvail";
            this.chkHideItemsOverAvail.Size = new System.Drawing.Size(353, 17);
            this.chkHideItemsOverAvail.TabIndex = 40;
            this.chkHideItemsOverAvail.Tag = "Checkbox_Option_HideItemsOverAvailLimit";
            this.chkHideItemsOverAvail.Text = "Hide items that are over the Availability Limit during character creation";
            this.chkHideItemsOverAvail.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkHideItemsOverAvail.UseVisualStyleBackColor = true;
            // 
            // flpEnablePlugins
            // 
            this.flpEnablePlugins.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flpEnablePlugins.AutoSize = true;
            this.flpEnablePlugins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGlobalOptions.SetColumnSpan(this.flpEnablePlugins, 3);
            this.flpEnablePlugins.Controls.Add(this.chkEnablePlugins);
            this.flpEnablePlugins.Controls.Add(this.cmdPluginsHelp);
            this.flpEnablePlugins.Location = new System.Drawing.Point(403, 208);
            this.flpEnablePlugins.Margin = new System.Windows.Forms.Padding(0);
            this.flpEnablePlugins.Name = "flpEnablePlugins";
            this.flpEnablePlugins.Size = new System.Drawing.Size(199, 29);
            this.flpEnablePlugins.TabIndex = 62;
            this.flpEnablePlugins.WrapContents = false;
            // 
            // chkEnablePlugins
            // 
            this.chkEnablePlugins.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkEnablePlugins.AutoSize = true;
            this.chkEnablePlugins.DefaultColorScheme = true;
            this.chkEnablePlugins.Location = new System.Drawing.Point(3, 6);
            this.chkEnablePlugins.Name = "chkEnablePlugins";
            this.chkEnablePlugins.Size = new System.Drawing.Size(164, 17);
            this.chkEnablePlugins.TabIndex = 51;
            this.chkEnablePlugins.Tag = "Checkbox_Options_EnablePlugins";
            this.chkEnablePlugins.Text = "Enable Plugins (experimental)";
            this.chkEnablePlugins.UseVisualStyleBackColor = true;
            this.chkEnablePlugins.CheckedChanged += new System.EventHandler(this.chkEnablePlugins_CheckedChanged);
            // 
            // cmdPluginsHelp
            // 
            this.cmdPluginsHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmdPluginsHelp.AutoSize = true;
            this.cmdPluginsHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdPluginsHelp.Location = new System.Drawing.Point(173, 3);
            this.cmdPluginsHelp.Name = "cmdPluginsHelp";
            this.cmdPluginsHelp.Size = new System.Drawing.Size(23, 23);
            this.cmdPluginsHelp.TabIndex = 57;
            this.cmdPluginsHelp.Text = "?";
            this.cmdPluginsHelp.UseVisualStyleBackColor = true;
            this.cmdPluginsHelp.Click += new System.EventHandler(this.cmdPluginsHelp_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGlobalOptions.SetColumnSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Controls.Add(this.txtCharacterRosterPath);
            this.flowLayoutPanel2.Controls.Add(this.cmdCharacterRoster);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(196, 540);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(242, 29);
            this.flowLayoutPanel2.TabIndex = 63;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // txtCharacterRosterPath
            // 
            this.txtCharacterRosterPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCharacterRosterPath.Location = new System.Drawing.Point(3, 4);
            this.txtCharacterRosterPath.Name = "txtCharacterRosterPath";
            this.txtCharacterRosterPath.ReadOnly = true;
            this.txtCharacterRosterPath.Size = new System.Drawing.Size(204, 20);
            this.txtCharacterRosterPath.TabIndex = 45;
            this.txtCharacterRosterPath.TextChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // cmdCharacterRoster
            // 
            this.cmdCharacterRoster.AutoSize = true;
            this.cmdCharacterRoster.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdCharacterRoster.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdCharacterRoster.Location = new System.Drawing.Point(213, 3);
            this.cmdCharacterRoster.Name = "cmdCharacterRoster";
            this.cmdCharacterRoster.Size = new System.Drawing.Size(26, 23);
            this.cmdCharacterRoster.TabIndex = 47;
            this.cmdCharacterRoster.Text = "...";
            this.cmdCharacterRoster.UseVisualStyleBackColor = true;
            this.cmdCharacterRoster.Click += new System.EventHandler(this.cmdCharacterRoster_Click);
            // 
            // cboPDFParameters
            // 
            this.cboPDFParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPDFParameters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPDFParameters.FormattingEnabled = true;
            this.cboPDFParameters.Location = new System.Drawing.Point(199, 572);
            this.cboPDFParameters.Name = "cboPDFParameters";
            this.cboPDFParameters.Size = new System.Drawing.Size(201, 21);
            this.cboPDFParameters.TabIndex = 26;
            this.cboPDFParameters.TooltipText = "";
            this.cboPDFParameters.SelectedIndexChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGlobalOptions.SetColumnSpan(this.flowLayoutPanel3, 2);
            this.flowLayoutPanel3.Controls.Add(this.txtPDFAppPath);
            this.flowLayoutPanel3.Controls.Add(this.cmdPDFAppPath);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(196, 596);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(242, 29);
            this.flowLayoutPanel3.TabIndex = 64;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // txtPDFAppPath
            // 
            this.txtPDFAppPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPDFAppPath.Location = new System.Drawing.Point(3, 4);
            this.txtPDFAppPath.Name = "txtPDFAppPath";
            this.txtPDFAppPath.ReadOnly = true;
            this.txtPDFAppPath.Size = new System.Drawing.Size(204, 20);
            this.txtPDFAppPath.TabIndex = 10;
            this.txtPDFAppPath.TextChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // cmdPDFAppPath
            // 
            this.cmdPDFAppPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmdPDFAppPath.AutoSize = true;
            this.cmdPDFAppPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdPDFAppPath.Location = new System.Drawing.Point(213, 3);
            this.cmdPDFAppPath.Name = "cmdPDFAppPath";
            this.cmdPDFAppPath.Size = new System.Drawing.Size(26, 23);
            this.cmdPDFAppPath.TabIndex = 11;
            this.cmdPDFAppPath.Text = "...";
            this.cmdPDFAppPath.UseVisualStyleBackColor = true;
            this.cmdPDFAppPath.Click += new System.EventHandler(this.cmdPDFAppPath_Click);
            // 
            // grpDateFormat
            // 
            this.grpDateFormat.AutoSize = true;
            this.grpDateFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGlobalOptions.SetColumnSpan(this.grpDateFormat, 2);
            this.grpDateFormat.Controls.Add(this.bufferedTableLayoutPanel2);
            this.grpDateFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDateFormat.Enabled = false;
            this.grpDateFormat.Location = new System.Drawing.Point(199, 56);
            this.grpDateFormat.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.grpDateFormat.Name = "grpDateFormat";
            this.grpDateFormat.Size = new System.Drawing.Size(339, 71);
            this.grpDateFormat.TabIndex = 59;
            this.grpDateFormat.TabStop = false;
            this.grpDateFormat.Tag = "Label_Options_DateFormat";
            this.grpDateFormat.Text = "Date Format";
            // 
            // bufferedTableLayoutPanel2
            // 
            this.bufferedTableLayoutPanel2.AutoSize = true;
            this.bufferedTableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bufferedTableLayoutPanel2.ColumnCount = 1;
            this.bufferedTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bufferedTableLayoutPanel2.Controls.Add(this.txtDateFormat, 0, 1);
            this.bufferedTableLayoutPanel2.Controls.Add(this.txtDateFormatView, 0, 0);
            this.bufferedTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bufferedTableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.bufferedTableLayoutPanel2.Name = "bufferedTableLayoutPanel2";
            this.bufferedTableLayoutPanel2.RowCount = 2;
            this.bufferedTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bufferedTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bufferedTableLayoutPanel2.Size = new System.Drawing.Size(333, 52);
            this.bufferedTableLayoutPanel2.TabIndex = 0;
            // 
            // txtDateFormat
            // 
            this.txtDateFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateFormat.Location = new System.Drawing.Point(3, 29);
            this.txtDateFormat.Name = "txtDateFormat";
            this.txtDateFormat.Size = new System.Drawing.Size(327, 20);
            this.txtDateFormat.TabIndex = 48;
            this.txtDateFormat.TextChanged += new System.EventHandler(this.txtDateFormat_TextChanged);
            // 
            // txtDateFormatView
            // 
            this.txtDateFormatView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateFormatView.Location = new System.Drawing.Point(3, 3);
            this.txtDateFormatView.Name = "txtDateFormatView";
            this.txtDateFormatView.ReadOnly = true;
            this.txtDateFormatView.Size = new System.Drawing.Size(327, 20);
            this.txtDateFormatView.TabIndex = 47;
            // 
            // lblMugshotCompression
            // 
            this.lblMugshotCompression.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMugshotCompression.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.lblMugshotCompression, 2);
            this.lblMugshotCompression.Location = new System.Drawing.Point(67, 520);
            this.lblMugshotCompression.Name = "lblMugshotCompression";
            this.lblMugshotCompression.Size = new System.Drawing.Size(126, 13);
            this.lblMugshotCompression.TabIndex = 65;
            this.lblMugshotCompression.Tag = "Label_Options_MugshotCompression";
            this.lblMugshotCompression.Text = "Mugshot Storage Format:";
            // 
            // nudBrowserVersion
            // 
            this.nudBrowserVersion.AutoSize = true;
            this.nudBrowserVersion.Location = new System.Drawing.Point(199, 490);
            this.nudBrowserVersion.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudBrowserVersion.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudBrowserVersion.Name = "nudBrowserVersion";
            this.nudBrowserVersion.Size = new System.Drawing.Size(35, 20);
            this.nudBrowserVersion.TabIndex = 54;
            this.nudBrowserVersion.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudBrowserVersion.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // cboMugshotCompression
            // 
            this.cboMugshotCompression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMugshotCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMugshotCompression.FormattingEnabled = true;
            this.cboMugshotCompression.Location = new System.Drawing.Point(199, 516);
            this.cboMugshotCompression.Name = "cboMugshotCompression";
            this.cboMugshotCompression.Size = new System.Drawing.Size(201, 21);
            this.cboMugshotCompression.TabIndex = 66;
            this.cboMugshotCompression.TooltipText = "";
            this.cboMugshotCompression.SelectedIndexChanged += new System.EventHandler(this.cboMugshotCompression_SelectedIndexChanged);
            // 
            // flpMugshotCompressionQuality
            // 
            this.flpMugshotCompressionQuality.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flpMugshotCompressionQuality.AutoSize = true;
            this.flpMugshotCompressionQuality.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGlobalOptions.SetColumnSpan(this.flpMugshotCompressionQuality, 3);
            this.flpMugshotCompressionQuality.Controls.Add(this.lblMugshotCompressionQuality);
            this.flpMugshotCompressionQuality.Controls.Add(this.nudMugshotCompressionQuality);
            this.flpMugshotCompressionQuality.Location = new System.Drawing.Point(403, 513);
            this.flpMugshotCompressionQuality.Margin = new System.Windows.Forms.Padding(0);
            this.flpMugshotCompressionQuality.Name = "flpMugshotCompressionQuality";
            this.flpMugshotCompressionQuality.Size = new System.Drawing.Size(127, 26);
            this.flpMugshotCompressionQuality.TabIndex = 68;
            this.flpMugshotCompressionQuality.WrapContents = false;
            // 
            // lblMugshotCompressionQuality
            // 
            this.lblMugshotCompressionQuality.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMugshotCompressionQuality.AutoSize = true;
            this.lblMugshotCompressionQuality.Location = new System.Drawing.Point(3, 6);
            this.lblMugshotCompressionQuality.Name = "lblMugshotCompressionQuality";
            this.lblMugshotCompressionQuality.Size = new System.Drawing.Size(74, 13);
            this.lblMugshotCompressionQuality.TabIndex = 67;
            this.lblMugshotCompressionQuality.Tag = "Label_Options_ImageQuality";
            this.lblMugshotCompressionQuality.Text = "Image Quality:";
            // 
            // nudMugshotCompressionQuality
            // 
            this.nudMugshotCompressionQuality.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudMugshotCompressionQuality.AutoSize = true;
            this.nudMugshotCompressionQuality.Location = new System.Drawing.Point(83, 3);
            this.nudMugshotCompressionQuality.Name = "nudMugshotCompressionQuality";
            this.nudMugshotCompressionQuality.Size = new System.Drawing.Size(41, 20);
            this.nudMugshotCompressionQuality.TabIndex = 68;
            this.nudMugshotCompressionQuality.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudMugshotCompressionQuality.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkCreateBackupOnCareer
            // 
            this.chkCreateBackupOnCareer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkCreateBackupOnCareer.AutoSize = true;
            this.chkCreateBackupOnCareer.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tlpGlobalOptions.SetColumnSpan(this.chkCreateBackupOnCareer, 3);
            this.chkCreateBackupOnCareer.DefaultColorScheme = true;
            this.chkCreateBackupOnCareer.Location = new System.Drawing.Point(3, 441);
            this.chkCreateBackupOnCareer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCreateBackupOnCareer.Name = "chkCreateBackupOnCareer";
            this.chkCreateBackupOnCareer.Size = new System.Drawing.Size(333, 17);
            this.chkCreateBackupOnCareer.TabIndex = 24;
            this.chkCreateBackupOnCareer.Tag = "Checkbox_Option_CreateBackupOnCareer";
            this.chkCreateBackupOnCareer.Text = "Create backup of characters before moving them to Career Mode";
            this.chkCreateBackupOnCareer.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkCreateBackupOnCareer.UseVisualStyleBackColor = true;
            this.chkCreateBackupOnCareer.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkHideCharacterRoster
            // 
            this.chkHideCharacterRoster.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkHideCharacterRoster.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkHideCharacterRoster, 3);
            this.chkHideCharacterRoster.DefaultColorScheme = true;
            this.chkHideCharacterRoster.Location = new System.Drawing.Point(406, 366);
            this.chkHideCharacterRoster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkHideCharacterRoster.Name = "chkHideCharacterRoster";
            this.chkHideCharacterRoster.Size = new System.Drawing.Size(149, 17);
            this.chkHideCharacterRoster.TabIndex = 35;
            this.chkHideCharacterRoster.Tag = "Checkbox_Options_HideCharacterRoster";
            this.chkHideCharacterRoster.Text = "Hide the Character Roster";
            this.chkHideCharacterRoster.UseVisualStyleBackColor = true;
            this.chkHideCharacterRoster.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkHideMasterIndex
            // 
            this.chkHideMasterIndex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkHideMasterIndex.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkHideMasterIndex, 3);
            this.chkHideMasterIndex.DefaultColorScheme = true;
            this.chkHideMasterIndex.Location = new System.Drawing.Point(406, 341);
            this.chkHideMasterIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkHideMasterIndex.Name = "chkHideMasterIndex";
            this.chkHideMasterIndex.Size = new System.Drawing.Size(130, 17);
            this.chkHideMasterIndex.TabIndex = 69;
            this.chkHideMasterIndex.Tag = "Checkbox_Options_HideMasterIndex";
            this.chkHideMasterIndex.Text = "Hide the Master Index";
            this.chkHideMasterIndex.UseVisualStyleBackColor = true;
            // 
            // chkAllowHoverIncrement
            // 
            this.chkAllowHoverIncrement.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAllowHoverIncrement.AutoSize = true;
            this.chkAllowHoverIncrement.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkAllowHoverIncrement.Checked = true;
            this.chkAllowHoverIncrement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tlpGlobalOptions.SetColumnSpan(this.chkAllowHoverIncrement, 3);
            this.chkAllowHoverIncrement.DefaultColorScheme = true;
            this.chkAllowHoverIncrement.Location = new System.Drawing.Point(406, 291);
            this.chkAllowHoverIncrement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAllowHoverIncrement.Name = "chkAllowHoverIncrement";
            this.chkAllowHoverIncrement.Size = new System.Drawing.Size(410, 17);
            this.chkAllowHoverIncrement.TabIndex = 41;
            this.chkAllowHoverIncrement.Tag = "Checkbox_Options_AllowHoverIncrement";
            this.chkAllowHoverIncrement.Text = "Allow incrementingvalues of numericupdown controls by hovering over the control";
            this.chkAllowHoverIncrement.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkAllowHoverIncrement.UseVisualStyleBackColor = true;
            this.chkAllowHoverIncrement.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkLifeModule
            // 
            this.chkLifeModule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkLifeModule.AutoSize = true;
            this.tlpGlobalOptions.SetColumnSpan(this.chkLifeModule, 3);
            this.chkLifeModule.DefaultColorScheme = true;
            this.chkLifeModule.Location = new System.Drawing.Point(406, 266);
            this.chkLifeModule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkLifeModule.Name = "chkLifeModule";
            this.chkLifeModule.Size = new System.Drawing.Size(117, 17);
            this.chkLifeModule.TabIndex = 22;
            this.chkLifeModule.Tag = "Checkbox_Options_UseLifeModule";
            this.chkLifeModule.Text = "Life modules visible";
            this.chkLifeModule.UseVisualStyleBackColor = true;
            this.chkLifeModule.CheckedChanged += new System.EventHandler(this.chkLifeModules_CheckedChanged);
            // 
            // tlpColorMode
            // 
            this.tlpColorMode.AutoSize = true;
            this.tlpColorMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpColorMode.ColumnCount = 2;
            this.tlpGlobalOptions.SetColumnSpan(this.tlpColorMode, 3);
            this.tlpColorMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpColorMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpColorMode.Controls.Add(this.cboColorMode, 1, 0);
            this.tlpColorMode.Controls.Add(this.lblColorMode, 0, 0);
            this.tlpColorMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpColorMode.Location = new System.Drawing.Point(0, 127);
            this.tlpColorMode.Margin = new System.Windows.Forms.Padding(0);
            this.tlpColorMode.Name = "tlpColorMode";
            this.tlpColorMode.RowCount = 1;
            this.tlpColorMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpColorMode.Size = new System.Drawing.Size(403, 27);
            this.tlpColorMode.TabIndex = 72;
            // 
            // cboColorMode
            // 
            this.cboColorMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColorMode.FormattingEnabled = true;
            this.cboColorMode.Location = new System.Drawing.Point(73, 3);
            this.cboColorMode.Name = "cboColorMode";
            this.cboColorMode.Size = new System.Drawing.Size(327, 21);
            this.cboColorMode.TabIndex = 71;
            this.cboColorMode.SelectedIndexChanged += new System.EventHandler(this.cboColorMode_SelectedIndexChanged);
            // 
            // lblColorMode
            // 
            this.lblColorMode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblColorMode.AutoSize = true;
            this.lblColorMode.Location = new System.Drawing.Point(3, 7);
            this.lblColorMode.Name = "lblColorMode";
            this.lblColorMode.Size = new System.Drawing.Size(64, 13);
            this.lblColorMode.TabIndex = 70;
            this.lblColorMode.Tag = "Label_Options_ColorMode";
            this.lblColorMode.Text = "Color Mode:";
            // 
            // gpbEditSourcebookInfo
            // 
            this.gpbEditSourcebookInfo.Controls.Add(this.lstGlobalSourcebookInfos);
            this.gpbEditSourcebookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbEditSourcebookInfo.Location = new System.Drawing.Point(3, 3);
            this.gpbEditSourcebookInfo.Name = "gpbEditSourcebookInfo";
            this.tlpGlobal.SetRowSpan(this.gpbEditSourcebookInfo, 2);
            this.gpbEditSourcebookInfo.Size = new System.Drawing.Size(295, 544);
            this.gpbEditSourcebookInfo.TabIndex = 65;
            this.gpbEditSourcebookInfo.TabStop = false;
            this.gpbEditSourcebookInfo.Tag = "Label_Options_EditSourcebookInfo";
            this.gpbEditSourcebookInfo.Text = "Edit Sourcebook Info";
            // 
            // lstGlobalSourcebookInfos
            // 
            this.lstGlobalSourcebookInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstGlobalSourcebookInfos.FormattingEnabled = true;
            this.lstGlobalSourcebookInfos.Location = new System.Drawing.Point(3, 16);
            this.lstGlobalSourcebookInfos.Name = "lstGlobalSourcebookInfos";
            this.lstGlobalSourcebookInfos.Size = new System.Drawing.Size(289, 525);
            this.lstGlobalSourcebookInfos.TabIndex = 48;
            this.lstGlobalSourcebookInfos.SelectedIndexChanged += new System.EventHandler(this.lstGlobalSourcebookInfos_SelectedIndexChanged);
            // 
            // tabCharacterOptions
            // 
            this.tabCharacterOptions.BackColor = System.Drawing.SystemColors.Control;
            this.tabCharacterOptions.Controls.Add(this.tlpCharacterOptions);
            this.tabCharacterOptions.Location = new System.Drawing.Point(4, 22);
            this.tabCharacterOptions.Name = "tabCharacterOptions";
            this.tabCharacterOptions.Padding = new System.Windows.Forms.Padding(9);
            this.tabCharacterOptions.Size = new System.Drawing.Size(1232, 568);
            this.tabCharacterOptions.TabIndex = 0;
            this.tabCharacterOptions.Tag = "Tab_Options_Character";
            this.tabCharacterOptions.Text = "Character Options";
            // 
            // tlpCharacterOptions
            // 
            this.tlpCharacterOptions.AutoSize = true;
            this.tlpCharacterOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCharacterOptions.ColumnCount = 5;
            this.tlpCharacterOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCharacterOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCharacterOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCharacterOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCharacterOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpCharacterOptions.Controls.Add(this.chkPrintExpenses, 1, 13);
            this.tlpCharacterOptions.Controls.Add(this.chkPrintSkillsWithZeroRating, 1, 12);
            this.tlpCharacterOptions.Controls.Add(this.chkDontUseCyberlimbCalculation, 1, 1);
            this.tlpCharacterOptions.Controls.Add(this.chkAllowSkillDiceRolling, 1, 2);
            this.tlpCharacterOptions.Controls.Add(this.chkEnforceCapacity, 1, 3);
            this.tlpCharacterOptions.Controls.Add(this.chkLicenseEachRestrictedItem, 1, 4);
            this.tlpCharacterOptions.Controls.Add(this.lblEssenceDecimals, 1, 10);
            this.tlpCharacterOptions.Controls.Add(this.lblNuyenDecimalsMaximumLabel, 1, 9);
            this.tlpCharacterOptions.Controls.Add(this.lblNuyenDecimalsMinimumLabel, 1, 8);
            this.tlpCharacterOptions.Controls.Add(this.chkDontRoundEssenceInternally, 1, 11);
            this.tlpCharacterOptions.Controls.Add(this.chkDronemods, 1, 5);
            this.tlpCharacterOptions.Controls.Add(this.chkRestrictRecoil, 1, 7);
            this.tlpCharacterOptions.Controls.Add(this.nudNuyenDecimalsMinimum, 3, 8);
            this.tlpCharacterOptions.Controls.Add(this.nudNuyenDecimalsMaximum, 3, 9);
            this.tlpCharacterOptions.Controls.Add(this.nudEssenceDecimals, 3, 10);
            this.tlpCharacterOptions.Controls.Add(this.chkDronemodsMaximumPilot, 1, 6);
            this.tlpCharacterOptions.Controls.Add(this.chkPrintFreeExpenses, 1, 14);
            this.tlpCharacterOptions.Controls.Add(this.lblLimbCount, 1, 0);
            this.tlpCharacterOptions.Controls.Add(this.cboLimbCount, 2, 0);
            this.tlpCharacterOptions.Controls.Add(this.cmdEnableSourcebooks, 0, 17);
            this.tlpCharacterOptions.Controls.Add(this.gpbSourcebook, 0, 0);
            this.tlpCharacterOptions.Controls.Add(this.chkPrintNotes, 1, 15);
            this.tlpCharacterOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCharacterOptions.Location = new System.Drawing.Point(9, 9);
            this.tlpCharacterOptions.Name = "tlpCharacterOptions";
            this.tlpCharacterOptions.RowCount = 18;
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCharacterOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterOptions.Size = new System.Drawing.Size(1214, 550);
            this.tlpCharacterOptions.TabIndex = 40;
            // 
            // chkPrintExpenses
            // 
            this.chkPrintExpenses.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkPrintExpenses.AutoSize = true;
            this.tlpCharacterOptions.SetColumnSpan(this.chkPrintExpenses, 4);
            this.chkPrintExpenses.DefaultColorScheme = true;
            this.chkPrintExpenses.Location = new System.Drawing.Point(304, 330);
            this.chkPrintExpenses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkPrintExpenses.Name = "chkPrintExpenses";
            this.chkPrintExpenses.Size = new System.Drawing.Size(184, 17);
            this.chkPrintExpenses.TabIndex = 12;
            this.chkPrintExpenses.Tag = "Checkbox_Options_PrintExpenses";
            this.chkPrintExpenses.Text = "Print Karma and Nuyen Expenses";
            this.chkPrintExpenses.UseVisualStyleBackColor = true;
            this.chkPrintExpenses.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkPrintSkillsWithZeroRating
            // 
            this.chkPrintSkillsWithZeroRating.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkPrintSkillsWithZeroRating.AutoSize = true;
            this.tlpCharacterOptions.SetColumnSpan(this.chkPrintSkillsWithZeroRating, 4);
            this.chkPrintSkillsWithZeroRating.DefaultColorScheme = true;
            this.chkPrintSkillsWithZeroRating.Location = new System.Drawing.Point(304, 305);
            this.chkPrintSkillsWithZeroRating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkPrintSkillsWithZeroRating.Name = "chkPrintSkillsWithZeroRating";
            this.chkPrintSkillsWithZeroRating.Size = new System.Drawing.Size(229, 17);
            this.chkPrintSkillsWithZeroRating.TabIndex = 11;
            this.chkPrintSkillsWithZeroRating.Tag = "Checkbox_Options_PrintAllSkills";
            this.chkPrintSkillsWithZeroRating.Text = "Print all Active Skills with Rating 0 or higher";
            this.chkPrintSkillsWithZeroRating.UseVisualStyleBackColor = true;
            this.chkPrintSkillsWithZeroRating.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkDontUseCyberlimbCalculation
            // 
            this.chkDontUseCyberlimbCalculation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkDontUseCyberlimbCalculation.AutoSize = true;
            this.tlpCharacterOptions.SetColumnSpan(this.chkDontUseCyberlimbCalculation, 4);
            this.chkDontUseCyberlimbCalculation.DefaultColorScheme = true;
            this.chkDontUseCyberlimbCalculation.Location = new System.Drawing.Point(304, 31);
            this.chkDontUseCyberlimbCalculation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDontUseCyberlimbCalculation.Name = "chkDontUseCyberlimbCalculation";
            this.chkDontUseCyberlimbCalculation.Size = new System.Drawing.Size(317, 17);
            this.chkDontUseCyberlimbCalculation.TabIndex = 19;
            this.chkDontUseCyberlimbCalculation.Tag = "Checkbox_Options_UseCyberlimbCalculation";
            this.chkDontUseCyberlimbCalculation.Text = "Do not use Cyberlimbs when calculating augmented Attributes";
            this.chkDontUseCyberlimbCalculation.UseVisualStyleBackColor = true;
            this.chkDontUseCyberlimbCalculation.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkAllowSkillDiceRolling
            // 
            this.chkAllowSkillDiceRolling.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAllowSkillDiceRolling.AutoSize = true;
            this.tlpCharacterOptions.SetColumnSpan(this.chkAllowSkillDiceRolling, 4);
            this.chkAllowSkillDiceRolling.DefaultColorScheme = true;
            this.chkAllowSkillDiceRolling.Location = new System.Drawing.Point(304, 56);
            this.chkAllowSkillDiceRolling.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAllowSkillDiceRolling.Name = "chkAllowSkillDiceRolling";
            this.chkAllowSkillDiceRolling.Size = new System.Drawing.Size(170, 17);
            this.chkAllowSkillDiceRolling.TabIndex = 10;
            this.chkAllowSkillDiceRolling.Tag = "Checkbox_Option_AllowSkillDiceRolling";
            this.chkAllowSkillDiceRolling.Text = "Allow dice rolling for dice pools";
            this.chkAllowSkillDiceRolling.UseVisualStyleBackColor = true;
            this.chkAllowSkillDiceRolling.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkEnforceCapacity
            // 
            this.chkEnforceCapacity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkEnforceCapacity.AutoSize = true;
            this.tlpCharacterOptions.SetColumnSpan(this.chkEnforceCapacity, 4);
            this.chkEnforceCapacity.DefaultColorScheme = true;
            this.chkEnforceCapacity.Location = new System.Drawing.Point(304, 81);
            this.chkEnforceCapacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkEnforceCapacity.Name = "chkEnforceCapacity";
            this.chkEnforceCapacity.Size = new System.Drawing.Size(132, 17);
            this.chkEnforceCapacity.TabIndex = 25;
            this.chkEnforceCapacity.Tag = "Checkbox_Option_EnforceCapacity";
            this.chkEnforceCapacity.Text = "Enforce Capacity limits";
            this.chkEnforceCapacity.UseVisualStyleBackColor = true;
            this.chkEnforceCapacity.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkLicenseEachRestrictedItem
            // 
            this.chkLicenseEachRestrictedItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkLicenseEachRestrictedItem.AutoSize = true;
            this.tlpCharacterOptions.SetColumnSpan(this.chkLicenseEachRestrictedItem, 4);
            this.chkLicenseEachRestrictedItem.DefaultColorScheme = true;
            this.chkLicenseEachRestrictedItem.Location = new System.Drawing.Point(304, 106);
            this.chkLicenseEachRestrictedItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkLicenseEachRestrictedItem.Name = "chkLicenseEachRestrictedItem";
            this.chkLicenseEachRestrictedItem.Size = new System.Drawing.Size(163, 17);
            this.chkLicenseEachRestrictedItem.TabIndex = 27;
            this.chkLicenseEachRestrictedItem.Tag = "Checkbox_Options_LicenseRestricted";
            this.chkLicenseEachRestrictedItem.Text = "License each Restricted item";
            this.chkLicenseEachRestrictedItem.UseVisualStyleBackColor = true;
            this.chkLicenseEachRestrictedItem.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblEssenceDecimals
            // 
            this.lblEssenceDecimals.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEssenceDecimals.AutoSize = true;
            this.tlpCharacterOptions.SetColumnSpan(this.lblEssenceDecimals, 2);
            this.lblEssenceDecimals.Location = new System.Drawing.Point(388, 258);
            this.lblEssenceDecimals.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblEssenceDecimals.Name = "lblEssenceDecimals";
            this.lblEssenceDecimals.Size = new System.Drawing.Size(230, 13);
            this.lblEssenceDecimals.TabIndex = 16;
            this.lblEssenceDecimals.Tag = "Label_Options_EssenceDecimals";
            this.lblEssenceDecimals.Text = "Number of decimal places to round Essence to:";
            // 
            // lblNuyenDecimalsMaximumLabel
            // 
            this.lblNuyenDecimalsMaximumLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNuyenDecimalsMaximumLabel.AutoSize = true;
            this.tlpCharacterOptions.SetColumnSpan(this.lblNuyenDecimalsMaximumLabel, 2);
            this.lblNuyenDecimalsMaximumLabel.Location = new System.Drawing.Point(360, 232);
            this.lblNuyenDecimalsMaximumLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNuyenDecimalsMaximumLabel.Name = "lblNuyenDecimalsMaximumLabel";
            this.lblNuyenDecimalsMaximumLabel.Size = new System.Drawing.Size(258, 13);
            this.lblNuyenDecimalsMaximumLabel.TabIndex = 32;
            this.lblNuyenDecimalsMaximumLabel.Tag = "Label_Options_NuyenDecimalsMaximum";
            this.lblNuyenDecimalsMaximumLabel.Text = "Maximum number of Nuyen decimal places to display:";
            // 
            // lblNuyenDecimalsMinimumLabel
            // 
            this.lblNuyenDecimalsMinimumLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNuyenDecimalsMinimumLabel.AutoSize = true;
            this.tlpCharacterOptions.SetColumnSpan(this.lblNuyenDecimalsMinimumLabel, 2);
            this.lblNuyenDecimalsMinimumLabel.Location = new System.Drawing.Point(363, 206);
            this.lblNuyenDecimalsMinimumLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNuyenDecimalsMinimumLabel.Name = "lblNuyenDecimalsMinimumLabel";
            this.lblNuyenDecimalsMinimumLabel.Size = new System.Drawing.Size(255, 13);
            this.lblNuyenDecimalsMinimumLabel.TabIndex = 30;
            this.lblNuyenDecimalsMinimumLabel.Tag = "Label_Options_NuyenDecimalsMinimum";
            this.lblNuyenDecimalsMinimumLabel.Text = "Minimum number of Nuyen decimal places to display:";
            // 
            // chkDontRoundEssenceInternally
            // 
            this.chkDontRoundEssenceInternally.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkDontRoundEssenceInternally.AutoSize = true;
            this.tlpCharacterOptions.SetColumnSpan(this.chkDontRoundEssenceInternally, 4);
            this.chkDontRoundEssenceInternally.DefaultColorScheme = true;
            this.chkDontRoundEssenceInternally.Location = new System.Drawing.Point(304, 281);
            this.chkDontRoundEssenceInternally.Name = "chkDontRoundEssenceInternally";
            this.chkDontRoundEssenceInternally.Size = new System.Drawing.Size(349, 17);
            this.chkDontRoundEssenceInternally.TabIndex = 18;
            this.chkDontRoundEssenceInternally.Tag = "Checkbox_Option_DontRoundEssenceInternally";
            this.chkDontRoundEssenceInternally.Text = "Only round Essence for display purposes, not for internal calculations";
            this.chkDontRoundEssenceInternally.UseVisualStyleBackColor = true;
            this.chkDontRoundEssenceInternally.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkDronemods
            // 
            this.chkDronemods.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkDronemods.AutoSize = true;
            this.tlpCharacterOptions.SetColumnSpan(this.chkDronemods, 4);
            this.chkDronemods.DefaultColorScheme = true;
            this.chkDronemods.Location = new System.Drawing.Point(304, 131);
            this.chkDronemods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDronemods.Name = "chkDronemods";
            this.chkDronemods.Size = new System.Drawing.Size(206, 17);
            this.chkDronemods.TabIndex = 36;
            this.chkDronemods.Tag = "Checkbox_Options_Dronemods";
            this.chkDronemods.Text = "Use Drone Modification rules (R5 122)";
            this.chkDronemods.UseVisualStyleBackColor = true;
            this.chkDronemods.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkRestrictRecoil
            // 
            this.chkRestrictRecoil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkRestrictRecoil.AutoSize = true;
            this.tlpCharacterOptions.SetColumnSpan(this.chkRestrictRecoil, 4);
            this.chkRestrictRecoil.DefaultColorScheme = true;
            this.chkRestrictRecoil.Location = new System.Drawing.Point(304, 179);
            this.chkRestrictRecoil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkRestrictRecoil.Name = "chkRestrictRecoil";
            this.chkRestrictRecoil.Size = new System.Drawing.Size(258, 17);
            this.chkRestrictRecoil.TabIndex = 26;
            this.chkRestrictRecoil.Tag = "Checkbox_Options_UseRestrictionsToRecoilCompensation";
            this.chkRestrictRecoil.Text = "Use Restrictions to Recoil Compensation (RG 53)";
            this.chkRestrictRecoil.UseVisualStyleBackColor = true;
            this.chkRestrictRecoil.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // nudNuyenDecimalsMinimum
            // 
            this.nudNuyenDecimalsMinimum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudNuyenDecimalsMinimum.AutoSize = true;
            this.nudNuyenDecimalsMinimum.Location = new System.Drawing.Point(624, 203);
            this.nudNuyenDecimalsMinimum.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.nudNuyenDecimalsMinimum.Name = "nudNuyenDecimalsMinimum";
            this.nudNuyenDecimalsMinimum.Size = new System.Drawing.Size(35, 20);
            this.nudNuyenDecimalsMinimum.TabIndex = 33;
            this.nudNuyenDecimalsMinimum.ValueChanged += new System.EventHandler(this.nudNuyenDecimalsMinimum_ValueChanged);
            // 
            // nudNuyenDecimalsMaximum
            // 
            this.nudNuyenDecimalsMaximum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudNuyenDecimalsMaximum.AutoSize = true;
            this.nudNuyenDecimalsMaximum.Location = new System.Drawing.Point(624, 229);
            this.nudNuyenDecimalsMaximum.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.nudNuyenDecimalsMaximum.Name = "nudNuyenDecimalsMaximum";
            this.nudNuyenDecimalsMaximum.Size = new System.Drawing.Size(35, 20);
            this.nudNuyenDecimalsMaximum.TabIndex = 34;
            this.nudNuyenDecimalsMaximum.ValueChanged += new System.EventHandler(this.nudNuyenDecimalsMaximum_ValueChanged);
            // 
            // nudEssenceDecimals
            // 
            this.nudEssenceDecimals.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudEssenceDecimals.AutoSize = true;
            this.nudEssenceDecimals.Location = new System.Drawing.Point(624, 255);
            this.nudEssenceDecimals.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.nudEssenceDecimals.Name = "nudEssenceDecimals";
            this.nudEssenceDecimals.Size = new System.Drawing.Size(35, 20);
            this.nudEssenceDecimals.TabIndex = 17;
            this.nudEssenceDecimals.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudEssenceDecimals.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkDronemodsMaximumPilot
            // 
            this.chkDronemodsMaximumPilot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkDronemodsMaximumPilot.AutoSize = true;
            this.tlpCharacterOptions.SetColumnSpan(this.chkDronemodsMaximumPilot, 3);
            this.chkDronemodsMaximumPilot.DefaultColorScheme = true;
            this.chkDronemodsMaximumPilot.Location = new System.Drawing.Point(324, 155);
            this.chkDronemodsMaximumPilot.Margin = new System.Windows.Forms.Padding(23, 3, 3, 3);
            this.chkDronemodsMaximumPilot.Name = "chkDronemodsMaximumPilot";
            this.chkDronemodsMaximumPilot.Size = new System.Drawing.Size(214, 17);
            this.chkDronemodsMaximumPilot.TabIndex = 37;
            this.chkDronemodsMaximumPilot.Tag = "Checkbox_Options_Dronemods_Pilot";
            this.chkDronemodsMaximumPilot.Text = "Use Maximum Attribute for Pilot Attribute";
            this.chkDronemodsMaximumPilot.UseVisualStyleBackColor = true;
            this.chkDronemodsMaximumPilot.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkPrintFreeExpenses
            // 
            this.chkPrintFreeExpenses.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkPrintFreeExpenses.AutoSize = true;
            this.tlpCharacterOptions.SetColumnSpan(this.chkPrintFreeExpenses, 3);
            this.chkPrintFreeExpenses.DefaultColorScheme = true;
            this.chkPrintFreeExpenses.Location = new System.Drawing.Point(324, 354);
            this.chkPrintFreeExpenses.Margin = new System.Windows.Forms.Padding(23, 3, 3, 3);
            this.chkPrintFreeExpenses.Name = "chkPrintFreeExpenses";
            this.chkPrintFreeExpenses.Size = new System.Drawing.Size(208, 17);
            this.chkPrintFreeExpenses.TabIndex = 13;
            this.chkPrintFreeExpenses.Tag = "Checkbox_Options_PrintFreeExpenses";
            this.chkPrintFreeExpenses.Text = "Print Free Karma and Nuyen Expenses";
            this.chkPrintFreeExpenses.UseVisualStyleBackColor = true;
            this.chkPrintFreeExpenses.CheckedChanged += new System.EventHandler(this.chkPrintFreeExpenses_CheckedChanged);
            // 
            // lblLimbCount
            // 
            this.lblLimbCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLimbCount.AutoSize = true;
            this.lblLimbCount.Location = new System.Drawing.Point(304, 7);
            this.lblLimbCount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLimbCount.Name = "lblLimbCount";
            this.lblLimbCount.Size = new System.Drawing.Size(131, 13);
            this.lblLimbCount.TabIndex = 0;
            this.lblLimbCount.Tag = "Label_Options_CyberlimbCount";
            this.lblLimbCount.Text = "Limb Count for Cyberlimbs:";
            // 
            // cboLimbCount
            // 
            this.cboLimbCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCharacterOptions.SetColumnSpan(this.cboLimbCount, 2);
            this.cboLimbCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLimbCount.FormattingEnabled = true;
            this.cboLimbCount.Location = new System.Drawing.Point(441, 3);
            this.cboLimbCount.Name = "cboLimbCount";
            this.cboLimbCount.Size = new System.Drawing.Size(218, 21);
            this.cboLimbCount.TabIndex = 1;
            this.cboLimbCount.TooltipText = "";
            this.cboLimbCount.SelectedIndexChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // cmdEnableSourcebooks
            // 
            this.cmdEnableSourcebooks.AutoSize = true;
            this.cmdEnableSourcebooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdEnableSourcebooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdEnableSourcebooks.Location = new System.Drawing.Point(3, 524);
            this.cmdEnableSourcebooks.Name = "cmdEnableSourcebooks";
            this.cmdEnableSourcebooks.Size = new System.Drawing.Size(295, 23);
            this.cmdEnableSourcebooks.TabIndex = 6;
            this.cmdEnableSourcebooks.Tag = "Button_ToggleSourcebooks";
            this.cmdEnableSourcebooks.Text = "Toggle all Sourcebooks On/Off";
            this.cmdEnableSourcebooks.UseVisualStyleBackColor = true;
            this.cmdEnableSourcebooks.Click += new System.EventHandler(this.cmdEnableSourcebooks_Click);
            // 
            // gpbSourcebook
            // 
            this.gpbSourcebook.Controls.Add(this.treSourcebook);
            this.gpbSourcebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbSourcebook.Location = new System.Drawing.Point(3, 3);
            this.gpbSourcebook.Name = "gpbSourcebook";
            this.tlpCharacterOptions.SetRowSpan(this.gpbSourcebook, 17);
            this.gpbSourcebook.Size = new System.Drawing.Size(295, 515);
            this.gpbSourcebook.TabIndex = 38;
            this.gpbSourcebook.TabStop = false;
            this.gpbSourcebook.Tag = "Label_Options_SourcebooksToUse";
            this.gpbSourcebook.Text = "Sourcebooks to Use";
            // 
            // treSourcebook
            // 
            this.treSourcebook.CheckBoxes = true;
            this.treSourcebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treSourcebook.Location = new System.Drawing.Point(3, 16);
            this.treSourcebook.Name = "treSourcebook";
            this.treSourcebook.ShowLines = false;
            this.treSourcebook.ShowPlusMinus = false;
            this.treSourcebook.ShowRootLines = false;
            this.treSourcebook.Size = new System.Drawing.Size(289, 496);
            this.treSourcebook.TabIndex = 1;
            this.treSourcebook.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.OptionsChanged);
            // 
            // chkPrintNotes
            // 
            this.chkPrintNotes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkPrintNotes.AutoSize = true;
            this.chkPrintNotes.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tlpCharacterOptions.SetColumnSpan(this.chkPrintNotes, 4);
            this.chkPrintNotes.DefaultColorScheme = true;
            this.chkPrintNotes.Location = new System.Drawing.Point(304, 377);
            this.chkPrintNotes.Name = "chkPrintNotes";
            this.chkPrintNotes.Size = new System.Drawing.Size(78, 17);
            this.chkPrintNotes.TabIndex = 14;
            this.chkPrintNotes.Tag = "Checkbox_Option_PrintNotes";
            this.chkPrintNotes.Text = "Print Notes";
            this.chkPrintNotes.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkPrintNotes.UseVisualStyleBackColor = true;
            this.chkPrintNotes.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // tabKarmaCosts
            // 
            this.tabKarmaCosts.BackColor = System.Drawing.SystemColors.Control;
            this.tabKarmaCosts.Controls.Add(this.tlpKarmaCosts);
            this.tabKarmaCosts.Location = new System.Drawing.Point(4, 22);
            this.tabKarmaCosts.Name = "tabKarmaCosts";
            this.tabKarmaCosts.Padding = new System.Windows.Forms.Padding(9);
            this.tabKarmaCosts.Size = new System.Drawing.Size(1232, 568);
            this.tabKarmaCosts.TabIndex = 1;
            this.tabKarmaCosts.Tag = "Tab_Options_KarmaCosts";
            this.tabKarmaCosts.Text = "Karma Costs";
            // 
            // tlpKarmaCosts
            // 
            this.tlpKarmaCosts.ColumnCount = 1;
            this.tlpKarmaCosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKarmaCosts.Controls.Add(this.cmdRestoreDefaultsKarma, 0, 1);
            this.tlpKarmaCosts.Controls.Add(this.tlpKarmaCostsList, 0, 0);
            this.tlpKarmaCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKarmaCosts.Location = new System.Drawing.Point(9, 9);
            this.tlpKarmaCosts.Name = "tlpKarmaCosts";
            this.tlpKarmaCosts.RowCount = 2;
            this.tlpKarmaCosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKarmaCosts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCosts.Size = new System.Drawing.Size(1214, 550);
            this.tlpKarmaCosts.TabIndex = 125;
            // 
            // cmdRestoreDefaultsKarma
            // 
            this.cmdRestoreDefaultsKarma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRestoreDefaultsKarma.AutoSize = true;
            this.cmdRestoreDefaultsKarma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdRestoreDefaultsKarma.Location = new System.Drawing.Point(1115, 524);
            this.cmdRestoreDefaultsKarma.Name = "cmdRestoreDefaultsKarma";
            this.cmdRestoreDefaultsKarma.Size = new System.Drawing.Size(96, 23);
            this.cmdRestoreDefaultsKarma.TabIndex = 108;
            this.cmdRestoreDefaultsKarma.Tag = "Button_Options_RestoreDefaults";
            this.cmdRestoreDefaultsKarma.Text = "Restore Defaults";
            this.cmdRestoreDefaultsKarma.UseVisualStyleBackColor = true;
            this.cmdRestoreDefaultsKarma.Click += new System.EventHandler(this.cmdRestoreDefaultsKarma_Click);
            // 
            // tlpKarmaCostsList
            // 
            this.tlpKarmaCostsList.AutoScroll = true;
            this.tlpKarmaCostsList.ColumnCount = 8;
            this.tlpKarmaCostsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpKarmaCostsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpKarmaCostsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpKarmaCostsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpKarmaCostsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpKarmaCostsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpKarmaCostsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpKarmaCostsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaNuyenPerExtra, 2, 14);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaNuyenPer, 1, 14);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaNuyenPer, 0, 14);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaImproveKnowledgeSkill, 0, 5);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaImproveKnowledgeSkill, 1, 5);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaImproveKnowledgeSkillExtra, 2, 5);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaImproveActiveSkill, 0, 6);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaImproveActiveSkill, 1, 6);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaImproveActiveSkillExtra, 2, 6);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaImproveSkillGroup, 0, 7);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaImproveSkillGroup, 1, 7);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaImproveSkillGroupExtra, 2, 7);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaAttribute, 0, 8);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaAttribute, 1, 8);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaAttributeExtra, 2, 8);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaQuality, 0, 9);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaQuality, 1, 9);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaQualityExtra, 2, 9);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaAlchemicalFocusExtra, 7, 0);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaAlchemicalFocus, 6, 0);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaAlchemicalFocus, 5, 0);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaBanishingFocus, 5, 1);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaBanishingFocus, 6, 1);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaBanishingFocusExtra, 7, 1);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaBindingFocus, 5, 2);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaBindingFocus, 6, 2);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaBindingFocusExtra, 7, 2);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaCenteringFocus, 5, 3);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaCenteringFocus, 6, 3);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaCenteringFocusExtra, 7, 3);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaCounterspellingFocus, 5, 4);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaCounterspellingFocus, 6, 4);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaCounterspellingFocusExtra, 7, 4);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaDisenchantingFocus, 5, 5);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaDisenchantingFocus, 6, 5);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaDisenchantingFocusExtra, 7, 5);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaFlexibleSignatureFocus, 5, 6);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaFlexibleSignatureFocus, 6, 6);
            this.tlpKarmaCostsList.Controls.Add(this.lblFlexibleSignatureFocusExtra, 7, 6);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaMaskingFocus, 5, 7);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaMaskingFocus, 6, 7);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaMaskingFocusExtra, 7, 7);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaPowerFocus, 5, 8);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaPowerFocus, 6, 8);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaPowerFocusExtra, 7, 8);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaQiFocus, 5, 9);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaQiFocus, 6, 9);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaQiFocusExtra, 7, 9);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaRitualSpellcastingFocus, 5, 10);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaRitualSpellcastingFocus, 6, 10);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaRitualSpellcastingFocusExtra, 7, 10);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaSpellcastingFocus, 5, 11);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaSpellcastingFocus, 6, 11);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaSpellcastingFocusExtra, 7, 11);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaSummoningFocus, 5, 12);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaSummoningFocus, 6, 12);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaSummoningFocusExtra, 7, 12);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaSustainingFocus, 5, 13);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaSustainingFocus, 6, 13);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaSustainingFocusExtra, 7, 13);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaSpellShapingFocus, 5, 14);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaSpellShapingFocusExtra, 7, 14);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaSpellShapingFocus, 6, 14);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaWeaponFocus, 5, 15);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaWeaponFocusExtra, 7, 15);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaWeaponFocus, 6, 15);
            this.tlpKarmaCostsList.Controls.Add(this.lblMetatypeCostsKarmaMultiplierLabel, 3, 13);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaNewAIAdvancedProgram, 3, 12);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaNewAIProgram, 3, 11);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaTechnique, 3, 10);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaNewComplexForm, 3, 9);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaSpell, 3, 8);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaLeaveGroup, 3, 7);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaJoinGroup, 3, 6);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaMetamagic, 3, 5);
            this.tlpKarmaCostsList.Controls.Add(this.nudMetatypeCostsKarmaMultiplier, 4, 13);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaNewAIAdvancedProgram, 4, 12);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaNewAIProgram, 4, 11);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaTechnique, 4, 10);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaNewComplexForm, 4, 9);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaSpell, 4, 8);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaLeaveGroup, 4, 7);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaJoinGroup, 4, 6);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaMetamagic, 4, 5);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaSpecialization, 4, 0);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaKnowledgeSpecialization, 4, 1);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaNewKnowledgeSkill, 4, 2);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaNewActiveSkill, 4, 3);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaNewSkillGroup, 4, 4);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaSpecialization, 3, 0);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaKnowledgeSpecialization, 3, 1);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaNewKnowledgeSkill, 3, 2);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaNewActiveSkill, 3, 3);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaNewSkillGroup, 3, 4);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaContact, 0, 0);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaContact, 1, 0);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaContactExtra, 2, 0);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaEnemy, 0, 1);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaEnemy, 1, 1);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaEnemyExtra, 2, 1);
            this.tlpKarmaCostsList.Controls.Add(this.lblNuyenPerBP, 3, 14);
            this.tlpKarmaCostsList.Controls.Add(this.nudNuyenPerBP, 4, 14);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaCarryover, 0, 2);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaCarryover, 1, 2);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaCarryoverExtra, 2, 2);
            this.tlpKarmaCostsList.Controls.Add(this.flpKarmaInitiation, 0, 3);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaInitiation, 1, 3);
            this.tlpKarmaCostsList.Controls.Add(this.flpKarmaInitiationExtra, 2, 3);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaSpirit, 0, 4);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaSpirit, 1, 4);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaSpiritExtra, 2, 4);
            this.tlpKarmaCostsList.Controls.Add(this.lblKarmaMysticAdeptPowerPoint, 0, 13);
            this.tlpKarmaCostsList.Controls.Add(this.nudKarmaMysticAdeptPowerPoint, 1, 13);
            this.tlpKarmaCostsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKarmaCostsList.Location = new System.Drawing.Point(3, 3);
            this.tlpKarmaCostsList.Name = "tlpKarmaCostsList";
            this.tlpKarmaCostsList.RowCount = 17;
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaCostsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKarmaCostsList.Size = new System.Drawing.Size(1208, 515);
            this.tlpKarmaCostsList.TabIndex = 124;
            // 
            // lblKarmaNuyenPerExtra
            // 
            this.lblKarmaNuyenPerExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaNuyenPerExtra.AutoSize = true;
            this.lblKarmaNuyenPerExtra.Location = new System.Drawing.Point(221, 369);
            this.lblKarmaNuyenPerExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaNuyenPerExtra.Name = "lblKarmaNuyenPerExtra";
            this.lblKarmaNuyenPerExtra.Size = new System.Drawing.Size(55, 13);
            this.lblKarmaNuyenPerExtra.TabIndex = 43;
            this.lblKarmaNuyenPerExtra.Tag = "Label_Options_PerKarma";
            this.lblKarmaNuyenPerExtra.Text = "per Karma";
            // 
            // nudKarmaNuyenPer
            // 
            this.nudKarmaNuyenPer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaNuyenPer.AutoSize = true;
            this.nudKarmaNuyenPer.Location = new System.Drawing.Point(155, 367);
            this.nudKarmaNuyenPer.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudKarmaNuyenPer.Name = "nudKarmaNuyenPer";
            this.nudKarmaNuyenPer.Size = new System.Drawing.Size(60, 20);
            this.nudKarmaNuyenPer.TabIndex = 42;
            this.nudKarmaNuyenPer.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaNuyenPer
            // 
            this.lblKarmaNuyenPer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaNuyenPer.AutoSize = true;
            this.lblKarmaNuyenPer.Location = new System.Drawing.Point(111, 369);
            this.lblKarmaNuyenPer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaNuyenPer.Name = "lblKarmaNuyenPer";
            this.lblKarmaNuyenPer.Size = new System.Drawing.Size(38, 13);
            this.lblKarmaNuyenPer.TabIndex = 41;
            this.lblKarmaNuyenPer.Tag = "Label_Options_Nuyen";
            this.lblKarmaNuyenPer.Text = "Nuyen";
            // 
            // lblKarmaImproveKnowledgeSkill
            // 
            this.lblKarmaImproveKnowledgeSkill.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaImproveKnowledgeSkill.AutoSize = true;
            this.lblKarmaImproveKnowledgeSkill.Location = new System.Drawing.Point(3, 135);
            this.lblKarmaImproveKnowledgeSkill.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaImproveKnowledgeSkill.Name = "lblKarmaImproveKnowledgeSkill";
            this.lblKarmaImproveKnowledgeSkill.Size = new System.Drawing.Size(146, 13);
            this.lblKarmaImproveKnowledgeSkill.TabIndex = 8;
            this.lblKarmaImproveKnowledgeSkill.Tag = "Label_Options_ImproveKnowledgeSkill";
            this.lblKarmaImproveKnowledgeSkill.Text = "Improve Knowledge Skill by 1";
            // 
            // nudKarmaImproveKnowledgeSkill
            // 
            this.nudKarmaImproveKnowledgeSkill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaImproveKnowledgeSkill.AutoSize = true;
            this.nudKarmaImproveKnowledgeSkill.Location = new System.Drawing.Point(155, 133);
            this.nudKarmaImproveKnowledgeSkill.Name = "nudKarmaImproveKnowledgeSkill";
            this.nudKarmaImproveKnowledgeSkill.Size = new System.Drawing.Size(60, 20);
            this.nudKarmaImproveKnowledgeSkill.TabIndex = 9;
            this.nudKarmaImproveKnowledgeSkill.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaImproveKnowledgeSkillExtra
            // 
            this.lblKarmaImproveKnowledgeSkillExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaImproveKnowledgeSkillExtra.AutoSize = true;
            this.lblKarmaImproveKnowledgeSkillExtra.Location = new System.Drawing.Point(221, 135);
            this.lblKarmaImproveKnowledgeSkillExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaImproveKnowledgeSkillExtra.Name = "lblKarmaImproveKnowledgeSkillExtra";
            this.lblKarmaImproveKnowledgeSkillExtra.Size = new System.Drawing.Size(71, 13);
            this.lblKarmaImproveKnowledgeSkillExtra.TabIndex = 10;
            this.lblKarmaImproveKnowledgeSkillExtra.Tag = "Label_Options_NewRating";
            this.lblKarmaImproveKnowledgeSkillExtra.Text = "x New Rating";
            // 
            // lblKarmaImproveActiveSkill
            // 
            this.lblKarmaImproveActiveSkill.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaImproveActiveSkill.AutoSize = true;
            this.lblKarmaImproveActiveSkill.Location = new System.Drawing.Point(26, 161);
            this.lblKarmaImproveActiveSkill.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaImproveActiveSkill.Name = "lblKarmaImproveActiveSkill";
            this.lblKarmaImproveActiveSkill.Size = new System.Drawing.Size(123, 13);
            this.lblKarmaImproveActiveSkill.TabIndex = 11;
            this.lblKarmaImproveActiveSkill.Tag = "Label_Options_ImproveActiveSkill";
            this.lblKarmaImproveActiveSkill.Text = "Improve Active Skill by 1";
            // 
            // nudKarmaImproveActiveSkill
            // 
            this.nudKarmaImproveActiveSkill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaImproveActiveSkill.AutoSize = true;
            this.nudKarmaImproveActiveSkill.Location = new System.Drawing.Point(155, 159);
            this.nudKarmaImproveActiveSkill.Name = "nudKarmaImproveActiveSkill";
            this.nudKarmaImproveActiveSkill.Size = new System.Drawing.Size(60, 20);
            this.nudKarmaImproveActiveSkill.TabIndex = 12;
            this.nudKarmaImproveActiveSkill.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaImproveActiveSkillExtra
            // 
            this.lblKarmaImproveActiveSkillExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaImproveActiveSkillExtra.AutoSize = true;
            this.lblKarmaImproveActiveSkillExtra.Location = new System.Drawing.Point(221, 161);
            this.lblKarmaImproveActiveSkillExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaImproveActiveSkillExtra.Name = "lblKarmaImproveActiveSkillExtra";
            this.lblKarmaImproveActiveSkillExtra.Size = new System.Drawing.Size(71, 13);
            this.lblKarmaImproveActiveSkillExtra.TabIndex = 13;
            this.lblKarmaImproveActiveSkillExtra.Tag = "Label_Options_NewRating";
            this.lblKarmaImproveActiveSkillExtra.Text = "x New Rating";
            // 
            // lblKarmaImproveSkillGroup
            // 
            this.lblKarmaImproveSkillGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaImproveSkillGroup.AutoSize = true;
            this.lblKarmaImproveSkillGroup.Location = new System.Drawing.Point(27, 187);
            this.lblKarmaImproveSkillGroup.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaImproveSkillGroup.Name = "lblKarmaImproveSkillGroup";
            this.lblKarmaImproveSkillGroup.Size = new System.Drawing.Size(122, 13);
            this.lblKarmaImproveSkillGroup.TabIndex = 14;
            this.lblKarmaImproveSkillGroup.Tag = "Label_Options_ImproveSkillGroup";
            this.lblKarmaImproveSkillGroup.Text = "Improve Skill Group by 1";
            // 
            // nudKarmaImproveSkillGroup
            // 
            this.nudKarmaImproveSkillGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaImproveSkillGroup.AutoSize = true;
            this.nudKarmaImproveSkillGroup.Location = new System.Drawing.Point(155, 185);
            this.nudKarmaImproveSkillGroup.Name = "nudKarmaImproveSkillGroup";
            this.nudKarmaImproveSkillGroup.Size = new System.Drawing.Size(60, 20);
            this.nudKarmaImproveSkillGroup.TabIndex = 15;
            this.nudKarmaImproveSkillGroup.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaImproveSkillGroupExtra
            // 
            this.lblKarmaImproveSkillGroupExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaImproveSkillGroupExtra.AutoSize = true;
            this.lblKarmaImproveSkillGroupExtra.Location = new System.Drawing.Point(221, 187);
            this.lblKarmaImproveSkillGroupExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaImproveSkillGroupExtra.Name = "lblKarmaImproveSkillGroupExtra";
            this.lblKarmaImproveSkillGroupExtra.Size = new System.Drawing.Size(71, 13);
            this.lblKarmaImproveSkillGroupExtra.TabIndex = 16;
            this.lblKarmaImproveSkillGroupExtra.Tag = "Label_Options_NewRating";
            this.lblKarmaImproveSkillGroupExtra.Text = "x New Rating";
            // 
            // lblKarmaAttribute
            // 
            this.lblKarmaAttribute.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaAttribute.AutoSize = true;
            this.lblKarmaAttribute.Location = new System.Drawing.Point(39, 213);
            this.lblKarmaAttribute.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaAttribute.Name = "lblKarmaAttribute";
            this.lblKarmaAttribute.Size = new System.Drawing.Size(110, 13);
            this.lblKarmaAttribute.TabIndex = 17;
            this.lblKarmaAttribute.Tag = "Label_Options_ImproveAttribute";
            this.lblKarmaAttribute.Text = "Improve Attribute by 1";
            // 
            // nudKarmaAttribute
            // 
            this.nudKarmaAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaAttribute.AutoSize = true;
            this.nudKarmaAttribute.Location = new System.Drawing.Point(155, 211);
            this.nudKarmaAttribute.Name = "nudKarmaAttribute";
            this.nudKarmaAttribute.Size = new System.Drawing.Size(60, 20);
            this.nudKarmaAttribute.TabIndex = 18;
            this.nudKarmaAttribute.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaAttributeExtra
            // 
            this.lblKarmaAttributeExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaAttributeExtra.AutoSize = true;
            this.lblKarmaAttributeExtra.Location = new System.Drawing.Point(221, 213);
            this.lblKarmaAttributeExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaAttributeExtra.Name = "lblKarmaAttributeExtra";
            this.lblKarmaAttributeExtra.Size = new System.Drawing.Size(71, 13);
            this.lblKarmaAttributeExtra.TabIndex = 19;
            this.lblKarmaAttributeExtra.Tag = "Label_Options_NewRating";
            this.lblKarmaAttributeExtra.Text = "x New Rating";
            // 
            // lblKarmaQuality
            // 
            this.lblKarmaQuality.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaQuality.AutoSize = true;
            this.lblKarmaQuality.Location = new System.Drawing.Point(16, 239);
            this.lblKarmaQuality.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaQuality.Name = "lblKarmaQuality";
            this.lblKarmaQuality.Size = new System.Drawing.Size(133, 13);
            this.lblKarmaQuality.TabIndex = 20;
            this.lblKarmaQuality.Tag = "Label_Options_Qualities";
            this.lblKarmaQuality.Text = "Positive / Negative Quality";
            // 
            // nudKarmaQuality
            // 
            this.nudKarmaQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaQuality.AutoSize = true;
            this.nudKarmaQuality.Location = new System.Drawing.Point(155, 237);
            this.nudKarmaQuality.Name = "nudKarmaQuality";
            this.nudKarmaQuality.Size = new System.Drawing.Size(60, 20);
            this.nudKarmaQuality.TabIndex = 21;
            this.nudKarmaQuality.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaQualityExtra
            // 
            this.lblKarmaQualityExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaQualityExtra.AutoSize = true;
            this.lblKarmaQualityExtra.Location = new System.Drawing.Point(221, 239);
            this.lblKarmaQualityExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaQualityExtra.Name = "lblKarmaQualityExtra";
            this.lblKarmaQualityExtra.Size = new System.Drawing.Size(53, 13);
            this.lblKarmaQualityExtra.TabIndex = 22;
            this.lblKarmaQualityExtra.Tag = "Label_Options_BPCost";
            this.lblKarmaQualityExtra.Text = "x BP Cost";
            // 
            // lblKarmaAlchemicalFocusExtra
            // 
            this.lblKarmaAlchemicalFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaAlchemicalFocusExtra.AutoSize = true;
            this.lblKarmaAlchemicalFocusExtra.Location = new System.Drawing.Point(782, 5);
            this.lblKarmaAlchemicalFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaAlchemicalFocusExtra.Name = "lblKarmaAlchemicalFocusExtra";
            this.lblKarmaAlchemicalFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaAlchemicalFocusExtra.TabIndex = 62;
            this.lblKarmaAlchemicalFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaAlchemicalFocusExtra.Text = "x Force";
            // 
            // nudKarmaAlchemicalFocus
            // 
            this.nudKarmaAlchemicalFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaAlchemicalFocus.AutoSize = true;
            this.nudKarmaAlchemicalFocus.Location = new System.Drawing.Point(735, 3);
            this.nudKarmaAlchemicalFocus.Name = "nudKarmaAlchemicalFocus";
            this.nudKarmaAlchemicalFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaAlchemicalFocus.TabIndex = 61;
            this.nudKarmaAlchemicalFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaAlchemicalFocus
            // 
            this.lblKarmaAlchemicalFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaAlchemicalFocus.AutoSize = true;
            this.lblKarmaAlchemicalFocus.Location = new System.Drawing.Point(639, 5);
            this.lblKarmaAlchemicalFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaAlchemicalFocus.Name = "lblKarmaAlchemicalFocus";
            this.lblKarmaAlchemicalFocus.Size = new System.Drawing.Size(90, 13);
            this.lblKarmaAlchemicalFocus.TabIndex = 60;
            this.lblKarmaAlchemicalFocus.Tag = "Label_Options_AlchemicalFocus";
            this.lblKarmaAlchemicalFocus.Text = "Alchemical Focus";
            // 
            // lblKarmaBanishingFocus
            // 
            this.lblKarmaBanishingFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaBanishingFocus.AutoSize = true;
            this.lblKarmaBanishingFocus.Location = new System.Drawing.Point(644, 31);
            this.lblKarmaBanishingFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaBanishingFocus.Name = "lblKarmaBanishingFocus";
            this.lblKarmaBanishingFocus.Size = new System.Drawing.Size(85, 13);
            this.lblKarmaBanishingFocus.TabIndex = 63;
            this.lblKarmaBanishingFocus.Tag = "Label_Options_BanishingFocus";
            this.lblKarmaBanishingFocus.Text = "Banishing Focus";
            // 
            // nudKarmaBanishingFocus
            // 
            this.nudKarmaBanishingFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaBanishingFocus.AutoSize = true;
            this.nudKarmaBanishingFocus.Location = new System.Drawing.Point(735, 29);
            this.nudKarmaBanishingFocus.Name = "nudKarmaBanishingFocus";
            this.nudKarmaBanishingFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaBanishingFocus.TabIndex = 64;
            this.nudKarmaBanishingFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaBanishingFocusExtra
            // 
            this.lblKarmaBanishingFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaBanishingFocusExtra.AutoSize = true;
            this.lblKarmaBanishingFocusExtra.Location = new System.Drawing.Point(782, 31);
            this.lblKarmaBanishingFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaBanishingFocusExtra.Name = "lblKarmaBanishingFocusExtra";
            this.lblKarmaBanishingFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaBanishingFocusExtra.TabIndex = 65;
            this.lblKarmaBanishingFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaBanishingFocusExtra.Text = "x Force";
            // 
            // lblKarmaBindingFocus
            // 
            this.lblKarmaBindingFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaBindingFocus.AutoSize = true;
            this.lblKarmaBindingFocus.Location = new System.Drawing.Point(655, 57);
            this.lblKarmaBindingFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaBindingFocus.Name = "lblKarmaBindingFocus";
            this.lblKarmaBindingFocus.Size = new System.Drawing.Size(74, 13);
            this.lblKarmaBindingFocus.TabIndex = 66;
            this.lblKarmaBindingFocus.Tag = "Label_Options_BindingFocus";
            this.lblKarmaBindingFocus.Text = "Binding Focus";
            // 
            // nudKarmaBindingFocus
            // 
            this.nudKarmaBindingFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaBindingFocus.AutoSize = true;
            this.nudKarmaBindingFocus.Location = new System.Drawing.Point(735, 55);
            this.nudKarmaBindingFocus.Name = "nudKarmaBindingFocus";
            this.nudKarmaBindingFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaBindingFocus.TabIndex = 67;
            this.nudKarmaBindingFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaBindingFocusExtra
            // 
            this.lblKarmaBindingFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaBindingFocusExtra.AutoSize = true;
            this.lblKarmaBindingFocusExtra.Location = new System.Drawing.Point(782, 57);
            this.lblKarmaBindingFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaBindingFocusExtra.Name = "lblKarmaBindingFocusExtra";
            this.lblKarmaBindingFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaBindingFocusExtra.TabIndex = 68;
            this.lblKarmaBindingFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaBindingFocusExtra.Text = "x Force";
            // 
            // lblKarmaCenteringFocus
            // 
            this.lblKarmaCenteringFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaCenteringFocus.AutoSize = true;
            this.lblKarmaCenteringFocus.Location = new System.Drawing.Point(645, 83);
            this.lblKarmaCenteringFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaCenteringFocus.Name = "lblKarmaCenteringFocus";
            this.lblKarmaCenteringFocus.Size = new System.Drawing.Size(84, 13);
            this.lblKarmaCenteringFocus.TabIndex = 69;
            this.lblKarmaCenteringFocus.Tag = "Label_Options_CenteringFocus";
            this.lblKarmaCenteringFocus.Text = "Centering Focus";
            // 
            // nudKarmaCenteringFocus
            // 
            this.nudKarmaCenteringFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaCenteringFocus.AutoSize = true;
            this.nudKarmaCenteringFocus.Location = new System.Drawing.Point(735, 81);
            this.nudKarmaCenteringFocus.Name = "nudKarmaCenteringFocus";
            this.nudKarmaCenteringFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaCenteringFocus.TabIndex = 70;
            this.nudKarmaCenteringFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaCenteringFocusExtra
            // 
            this.lblKarmaCenteringFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaCenteringFocusExtra.AutoSize = true;
            this.lblKarmaCenteringFocusExtra.Location = new System.Drawing.Point(782, 83);
            this.lblKarmaCenteringFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaCenteringFocusExtra.Name = "lblKarmaCenteringFocusExtra";
            this.lblKarmaCenteringFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaCenteringFocusExtra.TabIndex = 71;
            this.lblKarmaCenteringFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaCenteringFocusExtra.Text = "x Force";
            // 
            // lblKarmaCounterspellingFocus
            // 
            this.lblKarmaCounterspellingFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaCounterspellingFocus.AutoSize = true;
            this.lblKarmaCounterspellingFocus.Location = new System.Drawing.Point(618, 109);
            this.lblKarmaCounterspellingFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaCounterspellingFocus.Name = "lblKarmaCounterspellingFocus";
            this.lblKarmaCounterspellingFocus.Size = new System.Drawing.Size(111, 13);
            this.lblKarmaCounterspellingFocus.TabIndex = 72;
            this.lblKarmaCounterspellingFocus.Tag = "Label_Options_CounterspellingFocus";
            this.lblKarmaCounterspellingFocus.Text = "Counterspelling Focus";
            // 
            // nudKarmaCounterspellingFocus
            // 
            this.nudKarmaCounterspellingFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaCounterspellingFocus.AutoSize = true;
            this.nudKarmaCounterspellingFocus.Location = new System.Drawing.Point(735, 107);
            this.nudKarmaCounterspellingFocus.Name = "nudKarmaCounterspellingFocus";
            this.nudKarmaCounterspellingFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaCounterspellingFocus.TabIndex = 73;
            this.nudKarmaCounterspellingFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaCounterspellingFocusExtra
            // 
            this.lblKarmaCounterspellingFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaCounterspellingFocusExtra.AutoSize = true;
            this.lblKarmaCounterspellingFocusExtra.Location = new System.Drawing.Point(782, 109);
            this.lblKarmaCounterspellingFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaCounterspellingFocusExtra.Name = "lblKarmaCounterspellingFocusExtra";
            this.lblKarmaCounterspellingFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaCounterspellingFocusExtra.TabIndex = 74;
            this.lblKarmaCounterspellingFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaCounterspellingFocusExtra.Text = "x Force";
            // 
            // lblKarmaDisenchantingFocus
            // 
            this.lblKarmaDisenchantingFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaDisenchantingFocus.AutoSize = true;
            this.lblKarmaDisenchantingFocus.Location = new System.Drawing.Point(622, 135);
            this.lblKarmaDisenchantingFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaDisenchantingFocus.Name = "lblKarmaDisenchantingFocus";
            this.lblKarmaDisenchantingFocus.Size = new System.Drawing.Size(107, 13);
            this.lblKarmaDisenchantingFocus.TabIndex = 81;
            this.lblKarmaDisenchantingFocus.Tag = "Label_Options_DisenchantingFocus";
            this.lblKarmaDisenchantingFocus.Text = "Disenchanting Focus";
            // 
            // nudKarmaDisenchantingFocus
            // 
            this.nudKarmaDisenchantingFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaDisenchantingFocus.AutoSize = true;
            this.nudKarmaDisenchantingFocus.Location = new System.Drawing.Point(735, 133);
            this.nudKarmaDisenchantingFocus.Name = "nudKarmaDisenchantingFocus";
            this.nudKarmaDisenchantingFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaDisenchantingFocus.TabIndex = 82;
            this.nudKarmaDisenchantingFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaDisenchantingFocusExtra
            // 
            this.lblKarmaDisenchantingFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaDisenchantingFocusExtra.AutoSize = true;
            this.lblKarmaDisenchantingFocusExtra.Location = new System.Drawing.Point(782, 135);
            this.lblKarmaDisenchantingFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaDisenchantingFocusExtra.Name = "lblKarmaDisenchantingFocusExtra";
            this.lblKarmaDisenchantingFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaDisenchantingFocusExtra.TabIndex = 83;
            this.lblKarmaDisenchantingFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaDisenchantingFocusExtra.Text = "x Force";
            // 
            // lblKarmaFlexibleSignatureFocus
            // 
            this.lblKarmaFlexibleSignatureFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaFlexibleSignatureFocus.AutoSize = true;
            this.lblKarmaFlexibleSignatureFocus.Location = new System.Drawing.Point(607, 161);
            this.lblKarmaFlexibleSignatureFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaFlexibleSignatureFocus.Name = "lblKarmaFlexibleSignatureFocus";
            this.lblKarmaFlexibleSignatureFocus.Size = new System.Drawing.Size(122, 13);
            this.lblKarmaFlexibleSignatureFocus.TabIndex = 113;
            this.lblKarmaFlexibleSignatureFocus.Tag = "Label_Options_FlexibleSignatureFocus";
            this.lblKarmaFlexibleSignatureFocus.Text = "Flexible Signature Focus";
            // 
            // nudKarmaFlexibleSignatureFocus
            // 
            this.nudKarmaFlexibleSignatureFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaFlexibleSignatureFocus.AutoSize = true;
            this.nudKarmaFlexibleSignatureFocus.Location = new System.Drawing.Point(735, 159);
            this.nudKarmaFlexibleSignatureFocus.Name = "nudKarmaFlexibleSignatureFocus";
            this.nudKarmaFlexibleSignatureFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaFlexibleSignatureFocus.TabIndex = 114;
            this.nudKarmaFlexibleSignatureFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblFlexibleSignatureFocusExtra
            // 
            this.lblFlexibleSignatureFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFlexibleSignatureFocusExtra.AutoSize = true;
            this.lblFlexibleSignatureFocusExtra.Location = new System.Drawing.Point(782, 161);
            this.lblFlexibleSignatureFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblFlexibleSignatureFocusExtra.Name = "lblFlexibleSignatureFocusExtra";
            this.lblFlexibleSignatureFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblFlexibleSignatureFocusExtra.TabIndex = 115;
            this.lblFlexibleSignatureFocusExtra.Tag = "Label_Options_Force";
            this.lblFlexibleSignatureFocusExtra.Text = "x Force";
            // 
            // lblKarmaMaskingFocus
            // 
            this.lblKarmaMaskingFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaMaskingFocus.AutoSize = true;
            this.lblKarmaMaskingFocus.Location = new System.Drawing.Point(650, 187);
            this.lblKarmaMaskingFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaMaskingFocus.Name = "lblKarmaMaskingFocus";
            this.lblKarmaMaskingFocus.Size = new System.Drawing.Size(79, 13);
            this.lblKarmaMaskingFocus.TabIndex = 84;
            this.lblKarmaMaskingFocus.Tag = "Label_Options_MaskingFocus";
            this.lblKarmaMaskingFocus.Text = "Masking Focus";
            // 
            // nudKarmaMaskingFocus
            // 
            this.nudKarmaMaskingFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaMaskingFocus.AutoSize = true;
            this.nudKarmaMaskingFocus.Location = new System.Drawing.Point(735, 185);
            this.nudKarmaMaskingFocus.Name = "nudKarmaMaskingFocus";
            this.nudKarmaMaskingFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaMaskingFocus.TabIndex = 85;
            this.nudKarmaMaskingFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaMaskingFocusExtra
            // 
            this.lblKarmaMaskingFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaMaskingFocusExtra.AutoSize = true;
            this.lblKarmaMaskingFocusExtra.Location = new System.Drawing.Point(782, 187);
            this.lblKarmaMaskingFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaMaskingFocusExtra.Name = "lblKarmaMaskingFocusExtra";
            this.lblKarmaMaskingFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaMaskingFocusExtra.TabIndex = 86;
            this.lblKarmaMaskingFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaMaskingFocusExtra.Text = "x Force";
            // 
            // lblKarmaPowerFocus
            // 
            this.lblKarmaPowerFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaPowerFocus.AutoSize = true;
            this.lblKarmaPowerFocus.Location = new System.Drawing.Point(660, 213);
            this.lblKarmaPowerFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaPowerFocus.Name = "lblKarmaPowerFocus";
            this.lblKarmaPowerFocus.Size = new System.Drawing.Size(69, 13);
            this.lblKarmaPowerFocus.TabIndex = 87;
            this.lblKarmaPowerFocus.Tag = "Label_Options_PowerFocus";
            this.lblKarmaPowerFocus.Text = "Power Focus";
            // 
            // nudKarmaPowerFocus
            // 
            this.nudKarmaPowerFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaPowerFocus.AutoSize = true;
            this.nudKarmaPowerFocus.Location = new System.Drawing.Point(735, 211);
            this.nudKarmaPowerFocus.Name = "nudKarmaPowerFocus";
            this.nudKarmaPowerFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaPowerFocus.TabIndex = 88;
            this.nudKarmaPowerFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaPowerFocusExtra
            // 
            this.lblKarmaPowerFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaPowerFocusExtra.AutoSize = true;
            this.lblKarmaPowerFocusExtra.Location = new System.Drawing.Point(782, 213);
            this.lblKarmaPowerFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaPowerFocusExtra.Name = "lblKarmaPowerFocusExtra";
            this.lblKarmaPowerFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaPowerFocusExtra.TabIndex = 89;
            this.lblKarmaPowerFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaPowerFocusExtra.Text = "x Force";
            // 
            // lblKarmaQiFocus
            // 
            this.lblKarmaQiFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaQiFocus.AutoSize = true;
            this.lblKarmaQiFocus.Location = new System.Drawing.Point(680, 239);
            this.lblKarmaQiFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaQiFocus.Name = "lblKarmaQiFocus";
            this.lblKarmaQiFocus.Size = new System.Drawing.Size(49, 13);
            this.lblKarmaQiFocus.TabIndex = 90;
            this.lblKarmaQiFocus.Tag = "Label_Options_QiFocus";
            this.lblKarmaQiFocus.Text = "Qi Focus";
            // 
            // nudKarmaQiFocus
            // 
            this.nudKarmaQiFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaQiFocus.AutoSize = true;
            this.nudKarmaQiFocus.Location = new System.Drawing.Point(735, 237);
            this.nudKarmaQiFocus.Name = "nudKarmaQiFocus";
            this.nudKarmaQiFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaQiFocus.TabIndex = 91;
            this.nudKarmaQiFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaQiFocusExtra
            // 
            this.lblKarmaQiFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaQiFocusExtra.AutoSize = true;
            this.lblKarmaQiFocusExtra.Location = new System.Drawing.Point(782, 239);
            this.lblKarmaQiFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaQiFocusExtra.Name = "lblKarmaQiFocusExtra";
            this.lblKarmaQiFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaQiFocusExtra.TabIndex = 92;
            this.lblKarmaQiFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaQiFocusExtra.Text = "x Force";
            // 
            // lblKarmaRitualSpellcastingFocus
            // 
            this.lblKarmaRitualSpellcastingFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaRitualSpellcastingFocus.AutoSize = true;
            this.lblKarmaRitualSpellcastingFocus.Location = new System.Drawing.Point(603, 265);
            this.lblKarmaRitualSpellcastingFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaRitualSpellcastingFocus.Name = "lblKarmaRitualSpellcastingFocus";
            this.lblKarmaRitualSpellcastingFocus.Size = new System.Drawing.Size(126, 13);
            this.lblKarmaRitualSpellcastingFocus.TabIndex = 116;
            this.lblKarmaRitualSpellcastingFocus.Tag = "Label_Options_RitualSpellcastingFocus";
            this.lblKarmaRitualSpellcastingFocus.Text = "Ritual Spellcasting Focus";
            // 
            // nudKarmaRitualSpellcastingFocus
            // 
            this.nudKarmaRitualSpellcastingFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaRitualSpellcastingFocus.AutoSize = true;
            this.nudKarmaRitualSpellcastingFocus.Location = new System.Drawing.Point(735, 263);
            this.nudKarmaRitualSpellcastingFocus.Name = "nudKarmaRitualSpellcastingFocus";
            this.nudKarmaRitualSpellcastingFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaRitualSpellcastingFocus.TabIndex = 117;
            this.nudKarmaRitualSpellcastingFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaRitualSpellcastingFocusExtra
            // 
            this.lblKarmaRitualSpellcastingFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaRitualSpellcastingFocusExtra.AutoSize = true;
            this.lblKarmaRitualSpellcastingFocusExtra.Location = new System.Drawing.Point(782, 265);
            this.lblKarmaRitualSpellcastingFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaRitualSpellcastingFocusExtra.Name = "lblKarmaRitualSpellcastingFocusExtra";
            this.lblKarmaRitualSpellcastingFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaRitualSpellcastingFocusExtra.TabIndex = 118;
            this.lblKarmaRitualSpellcastingFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaRitualSpellcastingFocusExtra.Text = "x Force";
            // 
            // lblKarmaSpellcastingFocus
            // 
            this.lblKarmaSpellcastingFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaSpellcastingFocus.AutoSize = true;
            this.lblKarmaSpellcastingFocus.Location = new System.Drawing.Point(633, 291);
            this.lblKarmaSpellcastingFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaSpellcastingFocus.Name = "lblKarmaSpellcastingFocus";
            this.lblKarmaSpellcastingFocus.Size = new System.Drawing.Size(96, 13);
            this.lblKarmaSpellcastingFocus.TabIndex = 93;
            this.lblKarmaSpellcastingFocus.Tag = "Label_Options_SpellcastingFocus";
            this.lblKarmaSpellcastingFocus.Text = "Spellcasting Focus";
            // 
            // nudKarmaSpellcastingFocus
            // 
            this.nudKarmaSpellcastingFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaSpellcastingFocus.AutoSize = true;
            this.nudKarmaSpellcastingFocus.Location = new System.Drawing.Point(735, 289);
            this.nudKarmaSpellcastingFocus.Name = "nudKarmaSpellcastingFocus";
            this.nudKarmaSpellcastingFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaSpellcastingFocus.TabIndex = 94;
            this.nudKarmaSpellcastingFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaSpellcastingFocusExtra
            // 
            this.lblKarmaSpellcastingFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaSpellcastingFocusExtra.AutoSize = true;
            this.lblKarmaSpellcastingFocusExtra.Location = new System.Drawing.Point(782, 291);
            this.lblKarmaSpellcastingFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaSpellcastingFocusExtra.Name = "lblKarmaSpellcastingFocusExtra";
            this.lblKarmaSpellcastingFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaSpellcastingFocusExtra.TabIndex = 95;
            this.lblKarmaSpellcastingFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaSpellcastingFocusExtra.Text = "x Force";
            // 
            // lblKarmaSummoningFocus
            // 
            this.lblKarmaSummoningFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaSummoningFocus.AutoSize = true;
            this.lblKarmaSummoningFocus.Location = new System.Drawing.Point(635, 317);
            this.lblKarmaSummoningFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaSummoningFocus.Name = "lblKarmaSummoningFocus";
            this.lblKarmaSummoningFocus.Size = new System.Drawing.Size(94, 13);
            this.lblKarmaSummoningFocus.TabIndex = 96;
            this.lblKarmaSummoningFocus.Tag = "Label_Options_SummoningFocus";
            this.lblKarmaSummoningFocus.Text = "Summoning Focus";
            // 
            // nudKarmaSummoningFocus
            // 
            this.nudKarmaSummoningFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaSummoningFocus.AutoSize = true;
            this.nudKarmaSummoningFocus.Location = new System.Drawing.Point(735, 315);
            this.nudKarmaSummoningFocus.Name = "nudKarmaSummoningFocus";
            this.nudKarmaSummoningFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaSummoningFocus.TabIndex = 97;
            this.nudKarmaSummoningFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaSummoningFocusExtra
            // 
            this.lblKarmaSummoningFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaSummoningFocusExtra.AutoSize = true;
            this.lblKarmaSummoningFocusExtra.Location = new System.Drawing.Point(782, 317);
            this.lblKarmaSummoningFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaSummoningFocusExtra.Name = "lblKarmaSummoningFocusExtra";
            this.lblKarmaSummoningFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaSummoningFocusExtra.TabIndex = 98;
            this.lblKarmaSummoningFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaSummoningFocusExtra.Text = "x Force";
            // 
            // lblKarmaSustainingFocus
            // 
            this.lblKarmaSustainingFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaSustainingFocus.AutoSize = true;
            this.lblKarmaSustainingFocus.Location = new System.Drawing.Point(641, 343);
            this.lblKarmaSustainingFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaSustainingFocus.Name = "lblKarmaSustainingFocus";
            this.lblKarmaSustainingFocus.Size = new System.Drawing.Size(88, 13);
            this.lblKarmaSustainingFocus.TabIndex = 99;
            this.lblKarmaSustainingFocus.Tag = "Label_Options_SustainingFocus";
            this.lblKarmaSustainingFocus.Text = "Sustaining Focus";
            // 
            // nudKarmaSustainingFocus
            // 
            this.nudKarmaSustainingFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaSustainingFocus.AutoSize = true;
            this.nudKarmaSustainingFocus.Location = new System.Drawing.Point(735, 341);
            this.nudKarmaSustainingFocus.Name = "nudKarmaSustainingFocus";
            this.nudKarmaSustainingFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaSustainingFocus.TabIndex = 100;
            this.nudKarmaSustainingFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaSustainingFocusExtra
            // 
            this.lblKarmaSustainingFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaSustainingFocusExtra.AutoSize = true;
            this.lblKarmaSustainingFocusExtra.Location = new System.Drawing.Point(782, 343);
            this.lblKarmaSustainingFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaSustainingFocusExtra.Name = "lblKarmaSustainingFocusExtra";
            this.lblKarmaSustainingFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaSustainingFocusExtra.TabIndex = 101;
            this.lblKarmaSustainingFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaSustainingFocusExtra.Text = "x Force";
            // 
            // lblKarmaSpellShapingFocus
            // 
            this.lblKarmaSpellShapingFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaSpellShapingFocus.AutoSize = true;
            this.lblKarmaSpellShapingFocus.Location = new System.Drawing.Point(625, 369);
            this.lblKarmaSpellShapingFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaSpellShapingFocus.Name = "lblKarmaSpellShapingFocus";
            this.lblKarmaSpellShapingFocus.Size = new System.Drawing.Size(104, 13);
            this.lblKarmaSpellShapingFocus.TabIndex = 102;
            this.lblKarmaSpellShapingFocus.Tag = "Label_Options_SpellShapingFocus";
            this.lblKarmaSpellShapingFocus.Text = "Spell Shaping Focus";
            // 
            // lblKarmaSpellShapingFocusExtra
            // 
            this.lblKarmaSpellShapingFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaSpellShapingFocusExtra.AutoSize = true;
            this.lblKarmaSpellShapingFocusExtra.Location = new System.Drawing.Point(782, 369);
            this.lblKarmaSpellShapingFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaSpellShapingFocusExtra.Name = "lblKarmaSpellShapingFocusExtra";
            this.lblKarmaSpellShapingFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaSpellShapingFocusExtra.TabIndex = 104;
            this.lblKarmaSpellShapingFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaSpellShapingFocusExtra.Text = "x Force";
            // 
            // nudKarmaSpellShapingFocus
            // 
            this.nudKarmaSpellShapingFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaSpellShapingFocus.AutoSize = true;
            this.nudKarmaSpellShapingFocus.Location = new System.Drawing.Point(735, 367);
            this.nudKarmaSpellShapingFocus.Name = "nudKarmaSpellShapingFocus";
            this.nudKarmaSpellShapingFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaSpellShapingFocus.TabIndex = 103;
            this.nudKarmaSpellShapingFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaWeaponFocus
            // 
            this.lblKarmaWeaponFocus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaWeaponFocus.AutoSize = true;
            this.lblKarmaWeaponFocus.Location = new System.Drawing.Point(649, 395);
            this.lblKarmaWeaponFocus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaWeaponFocus.Name = "lblKarmaWeaponFocus";
            this.lblKarmaWeaponFocus.Size = new System.Drawing.Size(80, 13);
            this.lblKarmaWeaponFocus.TabIndex = 105;
            this.lblKarmaWeaponFocus.Tag = "Label_Options_WeaponFocus";
            this.lblKarmaWeaponFocus.Text = "Weapon Focus";
            // 
            // lblKarmaWeaponFocusExtra
            // 
            this.lblKarmaWeaponFocusExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaWeaponFocusExtra.AutoSize = true;
            this.lblKarmaWeaponFocusExtra.Location = new System.Drawing.Point(782, 395);
            this.lblKarmaWeaponFocusExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaWeaponFocusExtra.Name = "lblKarmaWeaponFocusExtra";
            this.lblKarmaWeaponFocusExtra.Size = new System.Drawing.Size(42, 13);
            this.lblKarmaWeaponFocusExtra.TabIndex = 107;
            this.lblKarmaWeaponFocusExtra.Tag = "Label_Options_Force";
            this.lblKarmaWeaponFocusExtra.Text = "x Force";
            // 
            // nudKarmaWeaponFocus
            // 
            this.nudKarmaWeaponFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaWeaponFocus.AutoSize = true;
            this.nudKarmaWeaponFocus.Location = new System.Drawing.Point(735, 393);
            this.nudKarmaWeaponFocus.Name = "nudKarmaWeaponFocus";
            this.nudKarmaWeaponFocus.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaWeaponFocus.TabIndex = 106;
            this.nudKarmaWeaponFocus.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblMetatypeCostsKarmaMultiplierLabel
            // 
            this.lblMetatypeCostsKarmaMultiplierLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMetatypeCostsKarmaMultiplierLabel.AutoSize = true;
            this.lblMetatypeCostsKarmaMultiplierLabel.Location = new System.Drawing.Point(380, 343);
            this.lblMetatypeCostsKarmaMultiplierLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblMetatypeCostsKarmaMultiplierLabel.Name = "lblMetatypeCostsKarmaMultiplierLabel";
            this.lblMetatypeCostsKarmaMultiplierLabel.Size = new System.Drawing.Size(152, 13);
            this.lblMetatypeCostsKarmaMultiplierLabel.TabIndex = 125;
            this.lblMetatypeCostsKarmaMultiplierLabel.Tag = "Label_Options_MetatypesCostKarma";
            this.lblMetatypeCostsKarmaMultiplierLabel.Text = "Metatype Karma Cost Multiplier";
            // 
            // lblKarmaNewAIAdvancedProgram
            // 
            this.lblKarmaNewAIAdvancedProgram.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaNewAIAdvancedProgram.AutoSize = true;
            this.lblKarmaNewAIAdvancedProgram.Location = new System.Drawing.Point(390, 317);
            this.lblKarmaNewAIAdvancedProgram.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaNewAIAdvancedProgram.Name = "lblKarmaNewAIAdvancedProgram";
            this.lblKarmaNewAIAdvancedProgram.Size = new System.Drawing.Size(142, 13);
            this.lblKarmaNewAIAdvancedProgram.TabIndex = 110;
            this.lblKarmaNewAIAdvancedProgram.Tag = "Label_Options_NewAIAdvancedProgram";
            this.lblKarmaNewAIAdvancedProgram.Text = "New Advanced Program (AI)";
            // 
            // lblKarmaNewAIProgram
            // 
            this.lblKarmaNewAIProgram.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaNewAIProgram.AutoSize = true;
            this.lblKarmaNewAIProgram.Location = new System.Drawing.Point(442, 291);
            this.lblKarmaNewAIProgram.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaNewAIProgram.Name = "lblKarmaNewAIProgram";
            this.lblKarmaNewAIProgram.Size = new System.Drawing.Size(90, 13);
            this.lblKarmaNewAIProgram.TabIndex = 109;
            this.lblKarmaNewAIProgram.Tag = "Label_Options_NewAIProgram";
            this.lblKarmaNewAIProgram.Text = "New Program (AI)";
            // 
            // lblKarmaTechnique
            // 
            this.lblKarmaTechnique.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaTechnique.AutoSize = true;
            this.lblKarmaTechnique.Location = new System.Drawing.Point(438, 265);
            this.lblKarmaTechnique.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaTechnique.Name = "lblKarmaTechnique";
            this.lblKarmaTechnique.Size = new System.Drawing.Size(94, 13);
            this.lblKarmaTechnique.TabIndex = 39;
            this.lblKarmaTechnique.Tag = "Label_Options_MartialArtTechnique";
            this.lblKarmaTechnique.Text = "Martial Art Technique";
            // 
            // lblKarmaNewComplexForm
            // 
            this.lblKarmaNewComplexForm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaNewComplexForm.AutoSize = true;
            this.lblKarmaNewComplexForm.Location = new System.Drawing.Point(434, 239);
            this.lblKarmaNewComplexForm.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaNewComplexForm.Name = "lblKarmaNewComplexForm";
            this.lblKarmaNewComplexForm.Size = new System.Drawing.Size(98, 13);
            this.lblKarmaNewComplexForm.TabIndex = 25;
            this.lblKarmaNewComplexForm.Tag = "Label_Options_NewComplexForm";
            this.lblKarmaNewComplexForm.Text = "New Complex Form";
            // 
            // lblKarmaSpell
            // 
            this.lblKarmaSpell.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaSpell.AutoSize = true;
            this.lblKarmaSpell.Location = new System.Drawing.Point(477, 213);
            this.lblKarmaSpell.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaSpell.Name = "lblKarmaSpell";
            this.lblKarmaSpell.Size = new System.Drawing.Size(55, 13);
            this.lblKarmaSpell.TabIndex = 23;
            this.lblKarmaSpell.Tag = "Label_Options_NewSpell";
            this.lblKarmaSpell.Text = "New Spell";
            // 
            // lblKarmaLeaveGroup
            // 
            this.lblKarmaLeaveGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaLeaveGroup.AutoSize = true;
            this.lblKarmaLeaveGroup.Location = new System.Drawing.Point(418, 187);
            this.lblKarmaLeaveGroup.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaLeaveGroup.Name = "lblKarmaLeaveGroup";
            this.lblKarmaLeaveGroup.Size = new System.Drawing.Size(114, 13);
            this.lblKarmaLeaveGroup.TabIndex = 58;
            this.lblKarmaLeaveGroup.Tag = "Label_Options_LeaveGroup";
            this.lblKarmaLeaveGroup.Text = "Leave Group/Network";
            // 
            // lblKarmaJoinGroup
            // 
            this.lblKarmaJoinGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaJoinGroup.AutoSize = true;
            this.lblKarmaJoinGroup.Location = new System.Drawing.Point(429, 161);
            this.lblKarmaJoinGroup.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaJoinGroup.Name = "lblKarmaJoinGroup";
            this.lblKarmaJoinGroup.Size = new System.Drawing.Size(103, 13);
            this.lblKarmaJoinGroup.TabIndex = 56;
            this.lblKarmaJoinGroup.Tag = "Label_Options_JoinGroup";
            this.lblKarmaJoinGroup.Text = "Join Group/Network";
            // 
            // lblKarmaMetamagic
            // 
            this.lblKarmaMetamagic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaMetamagic.AutoSize = true;
            this.lblKarmaMetamagic.Location = new System.Drawing.Point(378, 135);
            this.lblKarmaMetamagic.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaMetamagic.Name = "lblKarmaMetamagic";
            this.lblKarmaMetamagic.Size = new System.Drawing.Size(154, 13);
            this.lblKarmaMetamagic.TabIndex = 57;
            this.lblKarmaMetamagic.Tag = "Label_Options_Metamagics";
            this.lblKarmaMetamagic.Text = "Additional Metamagics/Echoes";
            // 
            // nudMetatypeCostsKarmaMultiplier
            // 
            this.nudMetatypeCostsKarmaMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMetatypeCostsKarmaMultiplier.AutoSize = true;
            this.nudMetatypeCostsKarmaMultiplier.Location = new System.Drawing.Point(538, 341);
            this.nudMetatypeCostsKarmaMultiplier.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMetatypeCostsKarmaMultiplier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMetatypeCostsKarmaMultiplier.Name = "nudMetatypeCostsKarmaMultiplier";
            this.nudMetatypeCostsKarmaMultiplier.Size = new System.Drawing.Size(59, 20);
            this.nudMetatypeCostsKarmaMultiplier.TabIndex = 124;
            this.nudMetatypeCostsKarmaMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMetatypeCostsKarmaMultiplier.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // nudKarmaNewAIAdvancedProgram
            // 
            this.nudKarmaNewAIAdvancedProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaNewAIAdvancedProgram.AutoSize = true;
            this.nudKarmaNewAIAdvancedProgram.Location = new System.Drawing.Point(538, 315);
            this.nudKarmaNewAIAdvancedProgram.Name = "nudKarmaNewAIAdvancedProgram";
            this.nudKarmaNewAIAdvancedProgram.Size = new System.Drawing.Size(59, 20);
            this.nudKarmaNewAIAdvancedProgram.TabIndex = 112;
            this.nudKarmaNewAIAdvancedProgram.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // nudKarmaNewAIProgram
            // 
            this.nudKarmaNewAIProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaNewAIProgram.AutoSize = true;
            this.nudKarmaNewAIProgram.Location = new System.Drawing.Point(538, 289);
            this.nudKarmaNewAIProgram.Name = "nudKarmaNewAIProgram";
            this.nudKarmaNewAIProgram.Size = new System.Drawing.Size(59, 20);
            this.nudKarmaNewAIProgram.TabIndex = 111;
            this.nudKarmaNewAIProgram.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // nudKarmaTechnique
            // 
            this.nudKarmaTechnique.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaTechnique.AutoSize = true;
            this.nudKarmaTechnique.Location = new System.Drawing.Point(538, 263);
            this.nudKarmaTechnique.Name = "nudKarmaTechnique";
            this.nudKarmaTechnique.Size = new System.Drawing.Size(59, 20);
            this.nudKarmaTechnique.TabIndex = 40;
            this.nudKarmaTechnique.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // nudKarmaNewComplexForm
            // 
            this.nudKarmaNewComplexForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaNewComplexForm.AutoSize = true;
            this.nudKarmaNewComplexForm.Location = new System.Drawing.Point(538, 237);
            this.nudKarmaNewComplexForm.Name = "nudKarmaNewComplexForm";
            this.nudKarmaNewComplexForm.Size = new System.Drawing.Size(59, 20);
            this.nudKarmaNewComplexForm.TabIndex = 26;
            this.nudKarmaNewComplexForm.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // nudKarmaSpell
            // 
            this.nudKarmaSpell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaSpell.AutoSize = true;
            this.nudKarmaSpell.Location = new System.Drawing.Point(538, 211);
            this.nudKarmaSpell.Name = "nudKarmaSpell";
            this.nudKarmaSpell.Size = new System.Drawing.Size(59, 20);
            this.nudKarmaSpell.TabIndex = 24;
            this.nudKarmaSpell.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // nudKarmaLeaveGroup
            // 
            this.nudKarmaLeaveGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaLeaveGroup.AutoSize = true;
            this.nudKarmaLeaveGroup.Location = new System.Drawing.Point(538, 185);
            this.nudKarmaLeaveGroup.Name = "nudKarmaLeaveGroup";
            this.nudKarmaLeaveGroup.Size = new System.Drawing.Size(59, 20);
            this.nudKarmaLeaveGroup.TabIndex = 59;
            this.nudKarmaLeaveGroup.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // nudKarmaJoinGroup
            // 
            this.nudKarmaJoinGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaJoinGroup.AutoSize = true;
            this.nudKarmaJoinGroup.Location = new System.Drawing.Point(538, 159);
            this.nudKarmaJoinGroup.Name = "nudKarmaJoinGroup";
            this.nudKarmaJoinGroup.Size = new System.Drawing.Size(59, 20);
            this.nudKarmaJoinGroup.TabIndex = 57;
            this.nudKarmaJoinGroup.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // nudKarmaMetamagic
            // 
            this.nudKarmaMetamagic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaMetamagic.AutoSize = true;
            this.nudKarmaMetamagic.Location = new System.Drawing.Point(538, 133);
            this.nudKarmaMetamagic.Name = "nudKarmaMetamagic";
            this.nudKarmaMetamagic.Size = new System.Drawing.Size(59, 20);
            this.nudKarmaMetamagic.TabIndex = 58;
            this.nudKarmaMetamagic.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // nudKarmaSpecialization
            // 
            this.nudKarmaSpecialization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaSpecialization.AutoSize = true;
            this.nudKarmaSpecialization.Location = new System.Drawing.Point(538, 3);
            this.nudKarmaSpecialization.Name = "nudKarmaSpecialization";
            this.nudKarmaSpecialization.Size = new System.Drawing.Size(59, 20);
            this.nudKarmaSpecialization.TabIndex = 1;
            this.nudKarmaSpecialization.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // nudKarmaKnowledgeSpecialization
            // 
            this.nudKarmaKnowledgeSpecialization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaKnowledgeSpecialization.AutoSize = true;
            this.nudKarmaKnowledgeSpecialization.Location = new System.Drawing.Point(538, 29);
            this.nudKarmaKnowledgeSpecialization.Name = "nudKarmaKnowledgeSpecialization";
            this.nudKarmaKnowledgeSpecialization.Size = new System.Drawing.Size(59, 20);
            this.nudKarmaKnowledgeSpecialization.TabIndex = 120;
            this.nudKarmaKnowledgeSpecialization.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // nudKarmaNewKnowledgeSkill
            // 
            this.nudKarmaNewKnowledgeSkill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaNewKnowledgeSkill.AutoSize = true;
            this.nudKarmaNewKnowledgeSkill.Location = new System.Drawing.Point(538, 55);
            this.nudKarmaNewKnowledgeSkill.Name = "nudKarmaNewKnowledgeSkill";
            this.nudKarmaNewKnowledgeSkill.Size = new System.Drawing.Size(59, 20);
            this.nudKarmaNewKnowledgeSkill.TabIndex = 3;
            this.nudKarmaNewKnowledgeSkill.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // nudKarmaNewActiveSkill
            // 
            this.nudKarmaNewActiveSkill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaNewActiveSkill.AutoSize = true;
            this.nudKarmaNewActiveSkill.Location = new System.Drawing.Point(538, 81);
            this.nudKarmaNewActiveSkill.Name = "nudKarmaNewActiveSkill";
            this.nudKarmaNewActiveSkill.Size = new System.Drawing.Size(59, 20);
            this.nudKarmaNewActiveSkill.TabIndex = 5;
            this.nudKarmaNewActiveSkill.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // nudKarmaNewSkillGroup
            // 
            this.nudKarmaNewSkillGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaNewSkillGroup.AutoSize = true;
            this.nudKarmaNewSkillGroup.Location = new System.Drawing.Point(538, 107);
            this.nudKarmaNewSkillGroup.Name = "nudKarmaNewSkillGroup";
            this.nudKarmaNewSkillGroup.Size = new System.Drawing.Size(59, 20);
            this.nudKarmaNewSkillGroup.TabIndex = 7;
            this.nudKarmaNewSkillGroup.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaSpecialization
            // 
            this.lblKarmaSpecialization.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaSpecialization.AutoSize = true;
            this.lblKarmaSpecialization.Location = new System.Drawing.Point(380, 5);
            this.lblKarmaSpecialization.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaSpecialization.Name = "lblKarmaSpecialization";
            this.lblKarmaSpecialization.Size = new System.Drawing.Size(152, 13);
            this.lblKarmaSpecialization.TabIndex = 0;
            this.lblKarmaSpecialization.Tag = "Label_Options_NewSpecialization";
            this.lblKarmaSpecialization.Text = "New Active Skill Specialization";
            // 
            // lblKarmaKnowledgeSpecialization
            // 
            this.lblKarmaKnowledgeSpecialization.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaKnowledgeSpecialization.AutoSize = true;
            this.lblKarmaKnowledgeSpecialization.Location = new System.Drawing.Point(357, 31);
            this.lblKarmaKnowledgeSpecialization.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaKnowledgeSpecialization.Name = "lblKarmaKnowledgeSpecialization";
            this.lblKarmaKnowledgeSpecialization.Size = new System.Drawing.Size(175, 13);
            this.lblKarmaKnowledgeSpecialization.TabIndex = 119;
            this.lblKarmaKnowledgeSpecialization.Tag = "Label_Options_NewKnoSpecialization";
            this.lblKarmaKnowledgeSpecialization.Text = "New Knowledge Skill Specialization";
            // 
            // lblKarmaNewKnowledgeSkill
            // 
            this.lblKarmaNewKnowledgeSkill.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaNewKnowledgeSkill.AutoSize = true;
            this.lblKarmaNewKnowledgeSkill.Location = new System.Drawing.Point(425, 57);
            this.lblKarmaNewKnowledgeSkill.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaNewKnowledgeSkill.Name = "lblKarmaNewKnowledgeSkill";
            this.lblKarmaNewKnowledgeSkill.Size = new System.Drawing.Size(107, 13);
            this.lblKarmaNewKnowledgeSkill.TabIndex = 2;
            this.lblKarmaNewKnowledgeSkill.Tag = "Label_Options_NewKnowledgeSkill";
            this.lblKarmaNewKnowledgeSkill.Text = "New Knowledge Skill";
            // 
            // lblKarmaNewActiveSkill
            // 
            this.lblKarmaNewActiveSkill.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaNewActiveSkill.AutoSize = true;
            this.lblKarmaNewActiveSkill.Location = new System.Drawing.Point(448, 83);
            this.lblKarmaNewActiveSkill.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaNewActiveSkill.Name = "lblKarmaNewActiveSkill";
            this.lblKarmaNewActiveSkill.Size = new System.Drawing.Size(84, 13);
            this.lblKarmaNewActiveSkill.TabIndex = 4;
            this.lblKarmaNewActiveSkill.Tag = "Label_Options_NewActiveSkill";
            this.lblKarmaNewActiveSkill.Text = "New Active Skill";
            // 
            // lblKarmaNewSkillGroup
            // 
            this.lblKarmaNewSkillGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaNewSkillGroup.AutoSize = true;
            this.lblKarmaNewSkillGroup.Location = new System.Drawing.Point(449, 109);
            this.lblKarmaNewSkillGroup.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaNewSkillGroup.Name = "lblKarmaNewSkillGroup";
            this.lblKarmaNewSkillGroup.Size = new System.Drawing.Size(83, 13);
            this.lblKarmaNewSkillGroup.TabIndex = 6;
            this.lblKarmaNewSkillGroup.Tag = "Label_Options_NewSkillGroup";
            this.lblKarmaNewSkillGroup.Text = "New Skill Group";
            // 
            // lblKarmaContact
            // 
            this.lblKarmaContact.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaContact.AutoSize = true;
            this.lblKarmaContact.Location = new System.Drawing.Point(100, 5);
            this.lblKarmaContact.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaContact.Name = "lblKarmaContact";
            this.lblKarmaContact.Size = new System.Drawing.Size(49, 13);
            this.lblKarmaContact.TabIndex = 44;
            this.lblKarmaContact.Tag = "Label_Options_Contacts";
            this.lblKarmaContact.Text = "Contacts";
            // 
            // nudKarmaContact
            // 
            this.nudKarmaContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaContact.AutoSize = true;
            this.nudKarmaContact.Location = new System.Drawing.Point(155, 3);
            this.nudKarmaContact.Name = "nudKarmaContact";
            this.nudKarmaContact.Size = new System.Drawing.Size(60, 20);
            this.nudKarmaContact.TabIndex = 45;
            this.nudKarmaContact.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaContactExtra
            // 
            this.lblKarmaContactExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaContactExtra.AutoSize = true;
            this.lblKarmaContactExtra.Location = new System.Drawing.Point(221, 5);
            this.lblKarmaContactExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaContactExtra.Name = "lblKarmaContactExtra";
            this.lblKarmaContactExtra.Size = new System.Drawing.Size(120, 13);
            this.lblKarmaContactExtra.TabIndex = 46;
            this.lblKarmaContactExtra.Tag = "Label_Options_ConnectionLoyalty";
            this.lblKarmaContactExtra.Text = "x (Connection + Loyalty)";
            // 
            // lblKarmaEnemy
            // 
            this.lblKarmaEnemy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaEnemy.AutoSize = true;
            this.lblKarmaEnemy.Location = new System.Drawing.Point(102, 31);
            this.lblKarmaEnemy.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaEnemy.Name = "lblKarmaEnemy";
            this.lblKarmaEnemy.Size = new System.Drawing.Size(47, 13);
            this.lblKarmaEnemy.TabIndex = 47;
            this.lblKarmaEnemy.Tag = "Label_Options_Enemies";
            this.lblKarmaEnemy.Text = "Enemies";
            // 
            // nudKarmaEnemy
            // 
            this.nudKarmaEnemy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaEnemy.AutoSize = true;
            this.nudKarmaEnemy.Location = new System.Drawing.Point(155, 29);
            this.nudKarmaEnemy.Name = "nudKarmaEnemy";
            this.nudKarmaEnemy.Size = new System.Drawing.Size(60, 20);
            this.nudKarmaEnemy.TabIndex = 48;
            this.nudKarmaEnemy.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaEnemyExtra
            // 
            this.lblKarmaEnemyExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaEnemyExtra.AutoSize = true;
            this.lblKarmaEnemyExtra.Location = new System.Drawing.Point(221, 31);
            this.lblKarmaEnemyExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaEnemyExtra.Name = "lblKarmaEnemyExtra";
            this.lblKarmaEnemyExtra.Size = new System.Drawing.Size(120, 13);
            this.lblKarmaEnemyExtra.TabIndex = 49;
            this.lblKarmaEnemyExtra.Tag = "Label_Options_ConnectionLoyalty";
            this.lblKarmaEnemyExtra.Text = "x (Connection + Loyalty)";
            // 
            // lblNuyenPerBP
            // 
            this.lblNuyenPerBP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNuyenPerBP.AutoSize = true;
            this.lblNuyenPerBP.Location = new System.Drawing.Point(443, 369);
            this.lblNuyenPerBP.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblNuyenPerBP.Name = "lblNuyenPerBP";
            this.lblNuyenPerBP.Size = new System.Drawing.Size(89, 13);
            this.lblNuyenPerBP.TabIndex = 126;
            this.lblNuyenPerBP.Tag = "Label_Options_NuyenPerBP";
            this.lblNuyenPerBP.Text = "Nuyen per Karma";
            // 
            // nudNuyenPerBP
            // 
            this.nudNuyenPerBP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNuyenPerBP.AutoSize = true;
            this.nudNuyenPerBP.Location = new System.Drawing.Point(538, 367);
            this.nudNuyenPerBP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNuyenPerBP.Name = "nudNuyenPerBP";
            this.nudNuyenPerBP.Size = new System.Drawing.Size(59, 20);
            this.nudNuyenPerBP.TabIndex = 127;
            this.nudNuyenPerBP.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudNuyenPerBP.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaCarryover
            // 
            this.lblKarmaCarryover.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaCarryover.AutoSize = true;
            this.lblKarmaCarryover.Location = new System.Drawing.Point(8, 57);
            this.lblKarmaCarryover.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaCarryover.Name = "lblKarmaCarryover";
            this.lblKarmaCarryover.Size = new System.Drawing.Size(141, 13);
            this.lblKarmaCarryover.TabIndex = 50;
            this.lblKarmaCarryover.Tag = "Label_Options_Carryover";
            this.lblKarmaCarryover.Text = "Carryover for New Character";
            // 
            // nudKarmaCarryover
            // 
            this.nudKarmaCarryover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaCarryover.AutoSize = true;
            this.nudKarmaCarryover.Location = new System.Drawing.Point(155, 55);
            this.nudKarmaCarryover.Name = "nudKarmaCarryover";
            this.nudKarmaCarryover.Size = new System.Drawing.Size(60, 20);
            this.nudKarmaCarryover.TabIndex = 51;
            this.nudKarmaCarryover.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaCarryoverExtra
            // 
            this.lblKarmaCarryoverExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaCarryoverExtra.AutoSize = true;
            this.lblKarmaCarryoverExtra.Location = new System.Drawing.Point(221, 57);
            this.lblKarmaCarryoverExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaCarryoverExtra.Name = "lblKarmaCarryoverExtra";
            this.lblKarmaCarryoverExtra.Size = new System.Drawing.Size(51, 13);
            this.lblKarmaCarryoverExtra.TabIndex = 52;
            this.lblKarmaCarryoverExtra.Tag = "Label_Options_Maximum";
            this.lblKarmaCarryoverExtra.Text = "Maximum";
            // 
            // flpKarmaInitiation
            // 
            this.flpKarmaInitiation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flpKarmaInitiation.AutoSize = true;
            this.flpKarmaInitiation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpKarmaInitiation.Controls.Add(this.lblKarmaInitiation);
            this.flpKarmaInitiation.Controls.Add(this.lblKarmaInitiationBracket);
            this.flpKarmaInitiation.Location = new System.Drawing.Point(18, 80);
            this.flpKarmaInitiation.Margin = new System.Windows.Forms.Padding(0);
            this.flpKarmaInitiation.Name = "flpKarmaInitiation";
            this.flpKarmaInitiation.Size = new System.Drawing.Size(134, 22);
            this.flpKarmaInitiation.TabIndex = 128;
            // 
            // lblKarmaInitiation
            // 
            this.lblKarmaInitiation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaInitiation.AutoSize = true;
            this.lblKarmaInitiation.Location = new System.Drawing.Point(3, 3);
            this.lblKarmaInitiation.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaInitiation.Name = "lblKarmaInitiation";
            this.lblKarmaInitiation.Size = new System.Drawing.Size(112, 13);
            this.lblKarmaInitiation.TabIndex = 53;
            this.lblKarmaInitiation.Tag = "Label_Options_Initiation";
            this.lblKarmaInitiation.Text = "Initiation / Submersion";
            // 
            // lblKarmaInitiationBracket
            // 
            this.lblKarmaInitiationBracket.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaInitiationBracket.AutoSize = true;
            this.lblKarmaInitiationBracket.Location = new System.Drawing.Point(121, 3);
            this.lblKarmaInitiationBracket.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaInitiationBracket.Name = "lblKarmaInitiationBracket";
            this.lblKarmaInitiationBracket.Size = new System.Drawing.Size(10, 13);
            this.lblKarmaInitiationBracket.TabIndex = 54;
            this.lblKarmaInitiationBracket.Text = "(";
            // 
            // nudKarmaInitiation
            // 
            this.nudKarmaInitiation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaInitiation.Location = new System.Drawing.Point(155, 81);
            this.nudKarmaInitiation.Name = "nudKarmaInitiation";
            this.nudKarmaInitiation.Size = new System.Drawing.Size(60, 20);
            this.nudKarmaInitiation.TabIndex = 55;
            this.nudKarmaInitiation.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // flpKarmaInitiationExtra
            // 
            this.flpKarmaInitiationExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flpKarmaInitiationExtra.AutoSize = true;
            this.flpKarmaInitiationExtra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpKarmaInitiationExtra.Controls.Add(this.lblKarmaInitiationExtra);
            this.flpKarmaInitiationExtra.Controls.Add(this.nudKarmaInitiationFlat);
            this.flpKarmaInitiationExtra.Location = new System.Drawing.Point(218, 78);
            this.flpKarmaInitiationExtra.Margin = new System.Windows.Forms.Padding(0);
            this.flpKarmaInitiationExtra.Name = "flpKarmaInitiationExtra";
            this.flpKarmaInitiationExtra.Size = new System.Drawing.Size(136, 26);
            this.flpKarmaInitiationExtra.TabIndex = 129;
            this.flpKarmaInitiationExtra.WrapContents = false;
            // 
            // lblKarmaInitiationExtra
            // 
            this.lblKarmaInitiationExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaInitiationExtra.AutoSize = true;
            this.lblKarmaInitiationExtra.Location = new System.Drawing.Point(3, 5);
            this.lblKarmaInitiationExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaInitiationExtra.Name = "lblKarmaInitiationExtra";
            this.lblKarmaInitiationExtra.Size = new System.Drawing.Size(83, 13);
            this.lblKarmaInitiationExtra.TabIndex = 56;
            this.lblKarmaInitiationExtra.Tag = "Label_Options_NewRatingPlus";
            this.lblKarmaInitiationExtra.Text = "x New Rating) +";
            // 
            // nudKarmaInitiationFlat
            // 
            this.nudKarmaInitiationFlat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudKarmaInitiationFlat.AutoSize = true;
            this.nudKarmaInitiationFlat.Location = new System.Drawing.Point(92, 3);
            this.nudKarmaInitiationFlat.Name = "nudKarmaInitiationFlat";
            this.nudKarmaInitiationFlat.Size = new System.Drawing.Size(41, 20);
            this.nudKarmaInitiationFlat.TabIndex = 121;
            this.nudKarmaInitiationFlat.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaSpirit
            // 
            this.lblKarmaSpirit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaSpirit.AutoSize = true;
            this.lblKarmaSpirit.Location = new System.Drawing.Point(119, 109);
            this.lblKarmaSpirit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaSpirit.Name = "lblKarmaSpirit";
            this.lblKarmaSpirit.Size = new System.Drawing.Size(30, 13);
            this.lblKarmaSpirit.TabIndex = 36;
            this.lblKarmaSpirit.Tag = "Label_Options_Spirit";
            this.lblKarmaSpirit.Text = "Spirit";
            // 
            // nudKarmaSpirit
            // 
            this.nudKarmaSpirit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaSpirit.AutoSize = true;
            this.nudKarmaSpirit.Location = new System.Drawing.Point(155, 107);
            this.nudKarmaSpirit.Name = "nudKarmaSpirit";
            this.nudKarmaSpirit.Size = new System.Drawing.Size(60, 20);
            this.nudKarmaSpirit.TabIndex = 37;
            this.nudKarmaSpirit.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // lblKarmaSpiritExtra
            // 
            this.lblKarmaSpiritExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKarmaSpiritExtra.AutoSize = true;
            this.lblKarmaSpiritExtra.Location = new System.Drawing.Point(221, 109);
            this.lblKarmaSpiritExtra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaSpiritExtra.Name = "lblKarmaSpiritExtra";
            this.lblKarmaSpiritExtra.Size = new System.Drawing.Size(87, 13);
            this.lblKarmaSpiritExtra.TabIndex = 38;
            this.lblKarmaSpiritExtra.Tag = "Label_Options_ServicesOwed";
            this.lblKarmaSpiritExtra.Text = "x Services Owed";
            // 
            // lblKarmaMysticAdeptPowerPoint
            // 
            this.lblKarmaMysticAdeptPowerPoint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarmaMysticAdeptPowerPoint.AutoSize = true;
            this.lblKarmaMysticAdeptPowerPoint.Location = new System.Drawing.Point(21, 343);
            this.lblKarmaMysticAdeptPowerPoint.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblKarmaMysticAdeptPowerPoint.Name = "lblKarmaMysticAdeptPowerPoint";
            this.lblKarmaMysticAdeptPowerPoint.Size = new System.Drawing.Size(128, 13);
            this.lblKarmaMysticAdeptPowerPoint.TabIndex = 122;
            this.lblKarmaMysticAdeptPowerPoint.Tag = "Label_Options_KarmaMysticAdeptPowerPoint";
            this.lblKarmaMysticAdeptPowerPoint.Text = "Mystic Adept Power Point";
            // 
            // nudKarmaMysticAdeptPowerPoint
            // 
            this.nudKarmaMysticAdeptPowerPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKarmaMysticAdeptPowerPoint.AutoSize = true;
            this.nudKarmaMysticAdeptPowerPoint.Location = new System.Drawing.Point(155, 341);
            this.nudKarmaMysticAdeptPowerPoint.Name = "nudKarmaMysticAdeptPowerPoint";
            this.nudKarmaMysticAdeptPowerPoint.Size = new System.Drawing.Size(60, 20);
            this.nudKarmaMysticAdeptPowerPoint.TabIndex = 123;
            this.nudKarmaMysticAdeptPowerPoint.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // tabOptionalRules
            // 
            this.tabOptionalRules.BackColor = System.Drawing.SystemColors.Control;
            this.tabOptionalRules.Controls.Add(this.tlpOptionalRules);
            this.tabOptionalRules.Location = new System.Drawing.Point(4, 22);
            this.tabOptionalRules.Name = "tabOptionalRules";
            this.tabOptionalRules.Padding = new System.Windows.Forms.Padding(9);
            this.tabOptionalRules.Size = new System.Drawing.Size(1232, 568);
            this.tabOptionalRules.TabIndex = 2;
            this.tabOptionalRules.Tag = "Tab_Options_OptionalRules";
            this.tabOptionalRules.Text = "Optional Rules";
            // 
            // tlpOptionalRules
            // 
            this.tlpOptionalRules.AutoSize = true;
            this.tlpOptionalRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOptionalRules.ColumnCount = 5;
            this.tlpOptionalRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpOptionalRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOptionalRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpOptionalRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpOptionalRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOptionalRules.Controls.Add(this.cmdDecreaseCustomDirectoryLoadOrder, 3, 2);
            this.tlpOptionalRules.Controls.Add(this.cmdIncreaseCustomDirectoryLoadOrder, 1, 2);
            this.tlpOptionalRules.Controls.Add(this.lblCustomDataDirectoriesLabel, 0, 0);
            this.tlpOptionalRules.Controls.Add(this.cmdAddCustomDirectory, 1, 0);
            this.tlpOptionalRules.Controls.Add(this.treCustomDataDirectories, 0, 1);
            this.tlpOptionalRules.Controls.Add(this.cmdRenameCustomDataDirectory, 2, 0);
            this.tlpOptionalRules.Controls.Add(this.cmdRemoveCustomDirectory, 4, 0);
            this.tlpOptionalRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptionalRules.Location = new System.Drawing.Point(9, 9);
            this.tlpOptionalRules.Name = "tlpOptionalRules";
            this.tlpOptionalRules.RowCount = 3;
            this.tlpOptionalRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptionalRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptionalRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptionalRules.Size = new System.Drawing.Size(1214, 550);
            this.tlpOptionalRules.TabIndex = 44;
            // 
            // cmdDecreaseCustomDirectoryLoadOrder
            // 
            this.cmdDecreaseCustomDirectoryLoadOrder.AutoSize = true;
            this.cmdDecreaseCustomDirectoryLoadOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOptionalRules.SetColumnSpan(this.cmdDecreaseCustomDirectoryLoadOrder, 2);
            this.cmdDecreaseCustomDirectoryLoadOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdDecreaseCustomDirectoryLoadOrder.Location = new System.Drawing.Point(1033, 524);
            this.cmdDecreaseCustomDirectoryLoadOrder.Name = "cmdDecreaseCustomDirectoryLoadOrder";
            this.cmdDecreaseCustomDirectoryLoadOrder.Size = new System.Drawing.Size(178, 23);
            this.cmdDecreaseCustomDirectoryLoadOrder.TabIndex = 42;
            this.cmdDecreaseCustomDirectoryLoadOrder.Tag = "Button_DecreaseCustomDirectoryLoadOrder";
            this.cmdDecreaseCustomDirectoryLoadOrder.Text = "Decrease Load Order";
            this.cmdDecreaseCustomDirectoryLoadOrder.UseVisualStyleBackColor = true;
            this.cmdDecreaseCustomDirectoryLoadOrder.Click += new System.EventHandler(this.cmdDecreaseCustomDirectoryLoadOrder_Click);
            // 
            // cmdIncreaseCustomDirectoryLoadOrder
            // 
            this.cmdIncreaseCustomDirectoryLoadOrder.AutoSize = true;
            this.cmdIncreaseCustomDirectoryLoadOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOptionalRules.SetColumnSpan(this.cmdIncreaseCustomDirectoryLoadOrder, 2);
            this.cmdIncreaseCustomDirectoryLoadOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdIncreaseCustomDirectoryLoadOrder.Location = new System.Drawing.Point(852, 524);
            this.cmdIncreaseCustomDirectoryLoadOrder.Name = "cmdIncreaseCustomDirectoryLoadOrder";
            this.cmdIncreaseCustomDirectoryLoadOrder.Size = new System.Drawing.Size(175, 23);
            this.cmdIncreaseCustomDirectoryLoadOrder.TabIndex = 43;
            this.cmdIncreaseCustomDirectoryLoadOrder.Tag = "Button_IncreaseCustomDirectoryLoadOrder";
            this.cmdIncreaseCustomDirectoryLoadOrder.Text = "Increase Load Order";
            this.cmdIncreaseCustomDirectoryLoadOrder.UseVisualStyleBackColor = true;
            this.cmdIncreaseCustomDirectoryLoadOrder.Click += new System.EventHandler(this.cmdIncreaseCustomDirectoryLoadOrder_Click);
            // 
            // lblCustomDataDirectoriesLabel
            // 
            this.lblCustomDataDirectoriesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustomDataDirectoriesLabel.AutoSize = true;
            this.lblCustomDataDirectoriesLabel.Location = new System.Drawing.Point(3, 8);
            this.lblCustomDataDirectoriesLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCustomDataDirectoriesLabel.Name = "lblCustomDataDirectoriesLabel";
            this.lblCustomDataDirectoriesLabel.Size = new System.Drawing.Size(358, 13);
            this.lblCustomDataDirectoriesLabel.TabIndex = 36;
            this.lblCustomDataDirectoriesLabel.Tag = "Label_Options_CustomDataDirectories";
            this.lblCustomDataDirectoriesLabel.Text = "Custom Data Directories to Use (Changes Are Only Applied After a Restart)";
            // 
            // cmdAddCustomDirectory
            // 
            this.cmdAddCustomDirectory.AutoSize = true;
            this.cmdAddCustomDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAddCustomDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdAddCustomDirectory.Location = new System.Drawing.Point(852, 3);
            this.cmdAddCustomDirectory.Name = "cmdAddCustomDirectory";
            this.cmdAddCustomDirectory.Size = new System.Drawing.Size(115, 23);
            this.cmdAddCustomDirectory.TabIndex = 38;
            this.cmdAddCustomDirectory.Tag = "Button_AddCustomDirectory";
            this.cmdAddCustomDirectory.Text = "Add Directory";
            this.cmdAddCustomDirectory.UseVisualStyleBackColor = true;
            this.cmdAddCustomDirectory.Click += new System.EventHandler(this.cmdAddCustomDirectory_Click);
            // 
            // treCustomDataDirectories
            // 
            this.treCustomDataDirectories.CheckBoxes = true;
            this.tlpOptionalRules.SetColumnSpan(this.treCustomDataDirectories, 5);
            this.treCustomDataDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treCustomDataDirectories.Location = new System.Drawing.Point(3, 32);
            this.treCustomDataDirectories.Name = "treCustomDataDirectories";
            this.treCustomDataDirectories.ShowLines = false;
            this.treCustomDataDirectories.ShowPlusMinus = false;
            this.treCustomDataDirectories.ShowRootLines = false;
            this.treCustomDataDirectories.Size = new System.Drawing.Size(1208, 486);
            this.treCustomDataDirectories.TabIndex = 40;
            this.treCustomDataDirectories.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treCustomDataDirectories_AfterCheck);
            // 
            // cmdRenameCustomDataDirectory
            // 
            this.cmdRenameCustomDataDirectory.AutoSize = true;
            this.cmdRenameCustomDataDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOptionalRules.SetColumnSpan(this.cmdRenameCustomDataDirectory, 2);
            this.cmdRenameCustomDataDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdRenameCustomDataDirectory.Location = new System.Drawing.Point(973, 3);
            this.cmdRenameCustomDataDirectory.Name = "cmdRenameCustomDataDirectory";
            this.cmdRenameCustomDataDirectory.Size = new System.Drawing.Size(114, 23);
            this.cmdRenameCustomDataDirectory.TabIndex = 41;
            this.cmdRenameCustomDataDirectory.Tag = "Button_RenameCustomDataDirectory";
            this.cmdRenameCustomDataDirectory.Text = "Rename Entry";
            this.cmdRenameCustomDataDirectory.UseVisualStyleBackColor = true;
            this.cmdRenameCustomDataDirectory.Click += new System.EventHandler(this.cmdRenameCustomDataDirectory_Click);
            // 
            // cmdRemoveCustomDirectory
            // 
            this.cmdRemoveCustomDirectory.AutoSize = true;
            this.cmdRemoveCustomDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdRemoveCustomDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdRemoveCustomDirectory.Location = new System.Drawing.Point(1093, 3);
            this.cmdRemoveCustomDirectory.Name = "cmdRemoveCustomDirectory";
            this.cmdRemoveCustomDirectory.Size = new System.Drawing.Size(118, 23);
            this.cmdRemoveCustomDirectory.TabIndex = 39;
            this.cmdRemoveCustomDirectory.Tag = "Button_RemoveCustomDirectory";
            this.cmdRemoveCustomDirectory.Text = "Remove Directory";
            this.cmdRemoveCustomDirectory.UseVisualStyleBackColor = true;
            this.cmdRemoveCustomDirectory.Click += new System.EventHandler(this.cmdRemoveCustomDirectory_Click);
            // 
            // tabHouseRules
            // 
            this.tabHouseRules.AutoScroll = true;
            this.tabHouseRules.BackColor = System.Drawing.SystemColors.Control;
            this.tabHouseRules.Controls.Add(this.tlpHouseRules);
            this.tabHouseRules.Location = new System.Drawing.Point(4, 22);
            this.tabHouseRules.Name = "tabHouseRules";
            this.tabHouseRules.Padding = new System.Windows.Forms.Padding(9);
            this.tabHouseRules.Size = new System.Drawing.Size(1232, 568);
            this.tabHouseRules.TabIndex = 3;
            this.tabHouseRules.Tag = "Tab_Options_HouseRules";
            this.tabHouseRules.Text = "House Rules";
            // 
            // tlpHouseRules
            // 
            this.tlpHouseRules.AutoScroll = true;
            this.tlpHouseRules.ColumnCount = 2;
            this.tlpHouseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHouseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHouseRules.Controls.Add(this.chkIgnoreArt, 0, 0);
            this.tlpHouseRules.Controls.Add(this.chkExceedNegativeQualitiesLimit, 1, 7);
            this.tlpHouseRules.Controls.Add(this.chkUseTotalValueForFreeKnowledge, 1, 3);
            this.tlpHouseRules.Controls.Add(this.chkExceedNegativeQualities, 1, 6);
            this.tlpHouseRules.Controls.Add(this.chkExceedPositiveQualitiesCostDoubled, 1, 5);
            this.tlpHouseRules.Controls.Add(this.chkExceedPositiveQualities, 1, 4);
            this.tlpHouseRules.Controls.Add(this.chkUnarmedSkillImprovements, 0, 1);
            this.tlpHouseRules.Controls.Add(this.chkCyberlegMovement, 0, 2);
            this.tlpHouseRules.Controls.Add(this.chkMysAdeptSecondMAGAttribute, 0, 19);
            this.tlpHouseRules.Controls.Add(this.chkDontDoubleQualityPurchases, 0, 3);
            this.tlpHouseRules.Controls.Add(this.chkAllowPointBuySpecializationsOnKarmaSkills, 0, 18);
            this.tlpHouseRules.Controls.Add(this.chkDontDoubleQualityRefunds, 0, 4);
            this.tlpHouseRules.Controls.Add(this.chkReverseAttributePriorityOrder, 0, 17);
            this.tlpHouseRules.Controls.Add(this.chkStrictSkillGroups, 0, 5);
            this.tlpHouseRules.Controls.Add(this.chkPrioritySpellsAsAdeptPowers, 0, 16);
            this.tlpHouseRules.Controls.Add(this.chkAllowInitiation, 0, 7);
            this.tlpHouseRules.Controls.Add(this.chkFreeMartialArtSpecialization, 0, 15);
            this.tlpHouseRules.Controls.Add(this.chkAllowCyberwareESSDiscounts, 0, 9);
            this.tlpHouseRules.Controls.Add(this.chkMysAdPp, 0, 14);
            this.tlpHouseRules.Controls.Add(this.chkESSLossReducesMaximumOnly, 0, 10);
            this.tlpHouseRules.Controls.Add(this.chkAlternateMetatypeAttributeKarma, 0, 13);
            this.tlpHouseRules.Controls.Add(this.chkUseCalculatedPublicAwareness, 0, 11);
            this.tlpHouseRules.Controls.Add(this.chkUseTotalValueForFreeContacts, 1, 1);
            this.tlpHouseRules.Controls.Add(this.chkIgnoreComplexFormLimit, 1, 16);
            this.tlpHouseRules.Controls.Add(this.chkSpecialKarmaCost, 1, 15);
            this.tlpHouseRules.Controls.Add(this.chkMoreLethalGameplay, 1, 12);
            this.tlpHouseRules.Controls.Add(this.chkExtendAnyDetectionSpell, 1, 11);
            this.tlpHouseRules.Controls.Add(this.chkAllowSkillRegrouping, 1, 9);
            this.tlpHouseRules.Controls.Add(this.chkNoArmorEncumbrance, 1, 10);
            this.tlpHouseRules.Controls.Add(this.chkIncreasedImprovedAbilityModifier, 1, 14);
            this.tlpHouseRules.Controls.Add(this.chkAllowFreeGrids, 1, 13);
            this.tlpHouseRules.Controls.Add(this.chkAllowTechnomancerSchooling, 0, 8);
            this.tlpHouseRules.Controls.Add(this.chkUsePointsOnBrokenGroups, 0, 6);
            this.tlpHouseRules.Controls.Add(this.flpDroneArmorMultiplier, 0, 12);
            this.tlpHouseRules.Controls.Add(this.flpContactMultiplier, 1, 0);
            this.tlpHouseRules.Controls.Add(this.flpKnowledgeMultiplier, 1, 2);
            this.tlpHouseRules.Controls.Add(this.flpCyberlimbAttributeBonusCap, 1, 17);
            this.tlpHouseRules.Controls.Add(this.chkUnclampAttributeMinimum, 1, 18);
            this.tlpHouseRules.Controls.Add(this.chkEnemyKarmaQualityLimit, 1, 8);
            this.tlpHouseRules.Controls.Add(this.chkCompensateSkillGroupKarmaDifference, 1, 19);
            this.tlpHouseRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHouseRules.Location = new System.Drawing.Point(9, 9);
            this.tlpHouseRules.Name = "tlpHouseRules";
            this.tlpHouseRules.RowCount = 21;
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHouseRules.Size = new System.Drawing.Size(1214, 550);
            this.tlpHouseRules.TabIndex = 39;
            // 
            // chkIgnoreArt
            // 
            this.chkIgnoreArt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkIgnoreArt.AutoSize = true;
            this.chkIgnoreArt.DefaultColorScheme = true;
            this.chkIgnoreArt.Location = new System.Drawing.Point(3, 4);
            this.chkIgnoreArt.Name = "chkIgnoreArt";
            this.chkIgnoreArt.Size = new System.Drawing.Size(235, 17);
            this.chkIgnoreArt.TabIndex = 1;
            this.chkIgnoreArt.Tag = "Checkbox_Options_IgnoreArt";
            this.chkIgnoreArt.Text = "Ignore Art Requirements from Street Grimoire";
            this.chkIgnoreArt.UseVisualStyleBackColor = true;
            this.chkIgnoreArt.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkExceedNegativeQualitiesLimit
            // 
            this.chkExceedNegativeQualitiesLimit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkExceedNegativeQualitiesLimit.AutoSize = true;
            this.chkExceedNegativeQualitiesLimit.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkExceedNegativeQualitiesLimit.DefaultColorScheme = true;
            this.chkExceedNegativeQualitiesLimit.Enabled = false;
            this.chkExceedNegativeQualitiesLimit.Location = new System.Drawing.Point(630, 170);
            this.chkExceedNegativeQualitiesLimit.Margin = new System.Windows.Forms.Padding(23, 3, 3, 3);
            this.chkExceedNegativeQualitiesLimit.Name = "chkExceedNegativeQualitiesLimit";
            this.chkExceedNegativeQualitiesLimit.Size = new System.Drawing.Size(503, 17);
            this.chkExceedNegativeQualitiesLimit.TabIndex = 18;
            this.chkExceedNegativeQualitiesLimit.Tag = "Checkbox_Options_ExceedNegativeQualitiesLimit";
            this.chkExceedNegativeQualitiesLimit.Text = "Characters do not gain Karma from taking Negative Qualities in excess of their Ga" +
    "meplay Option\'s limit";
            this.chkExceedNegativeQualitiesLimit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkExceedNegativeQualitiesLimit.UseVisualStyleBackColor = true;
            this.chkExceedNegativeQualitiesLimit.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkUseTotalValueForFreeKnowledge
            // 
            this.chkUseTotalValueForFreeKnowledge.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkUseTotalValueForFreeKnowledge.AutoSize = true;
            this.chkUseTotalValueForFreeKnowledge.DefaultColorScheme = true;
            this.chkUseTotalValueForFreeKnowledge.Location = new System.Drawing.Point(610, 78);
            this.chkUseTotalValueForFreeKnowledge.Name = "chkUseTotalValueForFreeKnowledge";
            this.chkUseTotalValueForFreeKnowledge.Size = new System.Drawing.Size(312, 17);
            this.chkUseTotalValueForFreeKnowledge.TabIndex = 24;
            this.chkUseTotalValueForFreeKnowledge.Tag = "Checkbox_Options_UseTotalValueForFreeKnowledge";
            this.chkUseTotalValueForFreeKnowledge.Text = "Free Knowledge Points use the augmented LOG+INT values";
            this.chkUseTotalValueForFreeKnowledge.UseVisualStyleBackColor = true;
            this.chkUseTotalValueForFreeKnowledge.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkExceedNegativeQualities
            // 
            this.chkExceedNegativeQualities.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkExceedNegativeQualities.AutoSize = true;
            this.chkExceedNegativeQualities.DefaultColorScheme = true;
            this.chkExceedNegativeQualities.Location = new System.Drawing.Point(610, 147);
            this.chkExceedNegativeQualities.Name = "chkExceedNegativeQualities";
            this.chkExceedNegativeQualities.Size = new System.Drawing.Size(278, 17);
            this.chkExceedNegativeQualities.TabIndex = 17;
            this.chkExceedNegativeQualities.Tag = "Checkbox_Options_ExceedNegativeQualities";
            this.chkExceedNegativeQualities.Text = "Allow characters to exceed their Negative Quality limit";
            this.chkExceedNegativeQualities.UseVisualStyleBackColor = true;
            this.chkExceedNegativeQualities.CheckedChanged += new System.EventHandler(this.chkExceedNegativeQualities_CheckedChanged);
            // 
            // chkExceedPositiveQualitiesCostDoubled
            // 
            this.chkExceedPositiveQualitiesCostDoubled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkExceedPositiveQualitiesCostDoubled.AutoSize = true;
            this.chkExceedPositiveQualitiesCostDoubled.DefaultColorScheme = true;
            this.chkExceedPositiveQualitiesCostDoubled.Enabled = false;
            this.chkExceedPositiveQualitiesCostDoubled.Location = new System.Drawing.Point(630, 124);
            this.chkExceedPositiveQualitiesCostDoubled.Margin = new System.Windows.Forms.Padding(23, 3, 3, 3);
            this.chkExceedPositiveQualitiesCostDoubled.Name = "chkExceedPositiveQualitiesCostDoubled";
            this.chkExceedPositiveQualitiesCostDoubled.Size = new System.Drawing.Size(367, 17);
            this.chkExceedPositiveQualitiesCostDoubled.TabIndex = 16;
            this.chkExceedPositiveQualitiesCostDoubled.Tag = "Checkbox_Options_ExceedPositiveQualitiesCostDoubled";
            this.chkExceedPositiveQualitiesCostDoubled.Text = "Use Career costs for all Positive Quality karma costs in excess of the limit";
            this.chkExceedPositiveQualitiesCostDoubled.UseVisualStyleBackColor = true;
            this.chkExceedPositiveQualitiesCostDoubled.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkExceedPositiveQualities
            // 
            this.chkExceedPositiveQualities.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkExceedPositiveQualities.AutoSize = true;
            this.chkExceedPositiveQualities.DefaultColorScheme = true;
            this.chkExceedPositiveQualities.Location = new System.Drawing.Point(610, 101);
            this.chkExceedPositiveQualities.Name = "chkExceedPositiveQualities";
            this.chkExceedPositiveQualities.Size = new System.Drawing.Size(272, 17);
            this.chkExceedPositiveQualities.TabIndex = 15;
            this.chkExceedPositiveQualities.Tag = "Checkbox_Options_ExceedPositiveQualities";
            this.chkExceedPositiveQualities.Text = "Allow characters to exceed their Positive Quality limit";
            this.chkExceedPositiveQualities.UseVisualStyleBackColor = true;
            this.chkExceedPositiveQualities.CheckedChanged += new System.EventHandler(this.chkExceedPositiveQualities_CheckedChanged);
            // 
            // chkUnarmedSkillImprovements
            // 
            this.chkUnarmedSkillImprovements.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkUnarmedSkillImprovements.AutoSize = true;
            this.chkUnarmedSkillImprovements.DefaultColorScheme = true;
            this.chkUnarmedSkillImprovements.Location = new System.Drawing.Point(3, 29);
            this.chkUnarmedSkillImprovements.Name = "chkUnarmedSkillImprovements";
            this.chkUnarmedSkillImprovements.Size = new System.Drawing.Size(372, 17);
            this.chkUnarmedSkillImprovements.TabIndex = 0;
            this.chkUnarmedSkillImprovements.Tag = "Checkbox_Options_UnarmedSkillImprovements";
            this.chkUnarmedSkillImprovements.Text = "Unarmed Combat-based Weapons Benefit from Unarmed Attack Bonuses";
            this.chkUnarmedSkillImprovements.UseVisualStyleBackColor = true;
            this.chkUnarmedSkillImprovements.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkCyberlegMovement
            // 
            this.chkCyberlegMovement.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkCyberlegMovement.AutoSize = true;
            this.chkCyberlegMovement.DefaultColorScheme = true;
            this.chkCyberlegMovement.Location = new System.Drawing.Point(3, 53);
            this.chkCyberlegMovement.Name = "chkCyberlegMovement";
            this.chkCyberlegMovement.Size = new System.Drawing.Size(184, 17);
            this.chkCyberlegMovement.TabIndex = 2;
            this.chkCyberlegMovement.Tag = "Checkbox_Options_CyberlegMovement";
            this.chkCyberlegMovement.Text = "Use Cyberleg Stats for Movement";
            this.chkCyberlegMovement.UseVisualStyleBackColor = true;
            this.chkCyberlegMovement.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkMysAdeptSecondMAGAttribute
            // 
            this.chkMysAdeptSecondMAGAttribute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkMysAdeptSecondMAGAttribute.AutoSize = true;
            this.chkMysAdeptSecondMAGAttribute.DefaultColorScheme = true;
            this.chkMysAdeptSecondMAGAttribute.Location = new System.Drawing.Point(3, 452);
            this.chkMysAdeptSecondMAGAttribute.Name = "chkMysAdeptSecondMAGAttribute";
            this.chkMysAdeptSecondMAGAttribute.Size = new System.Drawing.Size(428, 17);
            this.chkMysAdeptSecondMAGAttribute.TabIndex = 35;
            this.chkMysAdeptSecondMAGAttribute.Tag = "Checkbox_Options_MysAdeptSecondMAGAttribute";
            this.chkMysAdeptSecondMAGAttribute.Text = "Mystic Adepts use second MAG attribute for Adept abilities instead of special PP " +
    "rules";
            this.chkMysAdeptSecondMAGAttribute.UseVisualStyleBackColor = true;
            this.chkMysAdeptSecondMAGAttribute.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkDontDoubleQualityPurchases
            // 
            this.chkDontDoubleQualityPurchases.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkDontDoubleQualityPurchases.AutoSize = true;
            this.chkDontDoubleQualityPurchases.DefaultColorScheme = true;
            this.chkDontDoubleQualityPurchases.Location = new System.Drawing.Point(3, 78);
            this.chkDontDoubleQualityPurchases.Name = "chkDontDoubleQualityPurchases";
            this.chkDontDoubleQualityPurchases.Size = new System.Drawing.Size(352, 17);
            this.chkDontDoubleQualityPurchases.TabIndex = 5;
            this.chkDontDoubleQualityPurchases.Tag = "Checkbox_Options_DontDoubleQualityPurchases";
            this.chkDontDoubleQualityPurchases.Text = "Don\'t double the cost of purchasing Positive Qualities in Career Mode";
            this.chkDontDoubleQualityPurchases.UseVisualStyleBackColor = true;
            this.chkDontDoubleQualityPurchases.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkAllowPointBuySpecializationsOnKarmaSkills
            // 
            this.chkAllowPointBuySpecializationsOnKarmaSkills.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAllowPointBuySpecializationsOnKarmaSkills.AutoSize = true;
            this.chkAllowPointBuySpecializationsOnKarmaSkills.DefaultColorScheme = true;
            this.chkAllowPointBuySpecializationsOnKarmaSkills.Location = new System.Drawing.Point(3, 429);
            this.chkAllowPointBuySpecializationsOnKarmaSkills.Name = "chkAllowPointBuySpecializationsOnKarmaSkills";
            this.chkAllowPointBuySpecializationsOnKarmaSkills.Size = new System.Drawing.Size(366, 17);
            this.chkAllowPointBuySpecializationsOnKarmaSkills.TabIndex = 34;
            this.chkAllowPointBuySpecializationsOnKarmaSkills.Tag = "Checkbox_Options_AllowPointBuySpecializationsOnKarmaSkills";
            this.chkAllowPointBuySpecializationsOnKarmaSkills.Text = "Allow skill points to be used to buy specializations for karma-bought skills";
            this.chkAllowPointBuySpecializationsOnKarmaSkills.UseVisualStyleBackColor = true;
            this.chkAllowPointBuySpecializationsOnKarmaSkills.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkDontDoubleQualityRefunds
            // 
            this.chkDontDoubleQualityRefunds.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkDontDoubleQualityRefunds.AutoSize = true;
            this.chkDontDoubleQualityRefunds.DefaultColorScheme = true;
            this.chkDontDoubleQualityRefunds.Location = new System.Drawing.Point(3, 101);
            this.chkDontDoubleQualityRefunds.Name = "chkDontDoubleQualityRefunds";
            this.chkDontDoubleQualityRefunds.Size = new System.Drawing.Size(350, 17);
            this.chkDontDoubleQualityRefunds.TabIndex = 21;
            this.chkDontDoubleQualityRefunds.Tag = "Checkbox_Options_DontDoubleNegativeQualityRefunds";
            this.chkDontDoubleQualityRefunds.Text = "Don\'t double the cost of refunding Negative Qualities in Career Mode";
            this.chkDontDoubleQualityRefunds.UseVisualStyleBackColor = true;
            this.chkDontDoubleQualityRefunds.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkReverseAttributePriorityOrder
            // 
            this.chkReverseAttributePriorityOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkReverseAttributePriorityOrder.AutoSize = true;
            this.chkReverseAttributePriorityOrder.DefaultColorScheme = true;
            this.chkReverseAttributePriorityOrder.Location = new System.Drawing.Point(3, 404);
            this.chkReverseAttributePriorityOrder.Name = "chkReverseAttributePriorityOrder";
            this.chkReverseAttributePriorityOrder.Size = new System.Drawing.Size(251, 17);
            this.chkReverseAttributePriorityOrder.TabIndex = 33;
            this.chkReverseAttributePriorityOrder.Tag = "Checkbox_Options_ReverseAttributePriorityOrder";
            this.chkReverseAttributePriorityOrder.Text = "Spend Karma on Attributes before Priority Points";
            this.chkReverseAttributePriorityOrder.UseVisualStyleBackColor = true;
            this.chkReverseAttributePriorityOrder.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkStrictSkillGroups
            // 
            this.chkStrictSkillGroups.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkStrictSkillGroups.AutoSize = true;
            this.chkStrictSkillGroups.DefaultColorScheme = true;
            this.chkStrictSkillGroups.Location = new System.Drawing.Point(3, 124);
            this.chkStrictSkillGroups.Name = "chkStrictSkillGroups";
            this.chkStrictSkillGroups.Size = new System.Drawing.Size(304, 17);
            this.chkStrictSkillGroups.TabIndex = 6;
            this.chkStrictSkillGroups.Tag = "Checkbox_Options_StrictSkillGroups";
            this.chkStrictSkillGroups.Text = "Strict interprentation of breaking skill groups in create mode";
            this.chkStrictSkillGroups.UseVisualStyleBackColor = true;
            this.chkStrictSkillGroups.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkPrioritySpellsAsAdeptPowers
            // 
            this.chkPrioritySpellsAsAdeptPowers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkPrioritySpellsAsAdeptPowers.AutoSize = true;
            this.chkPrioritySpellsAsAdeptPowers.DefaultColorScheme = true;
            this.chkPrioritySpellsAsAdeptPowers.Location = new System.Drawing.Point(3, 380);
            this.chkPrioritySpellsAsAdeptPowers.Name = "chkPrioritySpellsAsAdeptPowers";
            this.chkPrioritySpellsAsAdeptPowers.Size = new System.Drawing.Size(325, 17);
            this.chkPrioritySpellsAsAdeptPowers.TabIndex = 31;
            this.chkPrioritySpellsAsAdeptPowers.Tag = "Checkbox_Option_PrioritySpellsAsAdeptPowers";
            this.chkPrioritySpellsAsAdeptPowers.Text = "Allow spending of free spells from Magic Priority as power points";
            this.chkPrioritySpellsAsAdeptPowers.UseVisualStyleBackColor = true;
            this.chkPrioritySpellsAsAdeptPowers.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkAllowInitiation
            // 
            this.chkAllowInitiation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAllowInitiation.AutoSize = true;
            this.chkAllowInitiation.DefaultColorScheme = true;
            this.chkAllowInitiation.Location = new System.Drawing.Point(3, 170);
            this.chkAllowInitiation.Name = "chkAllowInitiation";
            this.chkAllowInitiation.Size = new System.Drawing.Size(227, 17);
            this.chkAllowInitiation.TabIndex = 7;
            this.chkAllowInitiation.Tag = "Checkbox_Options_AllowInitiation";
            this.chkAllowInitiation.Text = "Allow Initiation/Submersion in Create mode";
            this.chkAllowInitiation.UseVisualStyleBackColor = true;
            this.chkAllowInitiation.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkFreeMartialArtSpecialization
            // 
            this.chkFreeMartialArtSpecialization.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkFreeMartialArtSpecialization.AutoSize = true;
            this.chkFreeMartialArtSpecialization.DefaultColorScheme = true;
            this.chkFreeMartialArtSpecialization.Location = new System.Drawing.Point(3, 357);
            this.chkFreeMartialArtSpecialization.Name = "chkFreeMartialArtSpecialization";
            this.chkFreeMartialArtSpecialization.Size = new System.Drawing.Size(281, 17);
            this.chkFreeMartialArtSpecialization.TabIndex = 30;
            this.chkFreeMartialArtSpecialization.Tag = "Checkbox_Option_FreeMartialArtSpecialization";
            this.chkFreeMartialArtSpecialization.Text = "Allow Martial Arts to grant a free specialisation in a skill";
            this.chkFreeMartialArtSpecialization.UseVisualStyleBackColor = true;
            this.chkFreeMartialArtSpecialization.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkAllowCyberwareESSDiscounts
            // 
            this.chkAllowCyberwareESSDiscounts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAllowCyberwareESSDiscounts.AutoSize = true;
            this.chkAllowCyberwareESSDiscounts.DefaultColorScheme = true;
            this.chkAllowCyberwareESSDiscounts.Location = new System.Drawing.Point(3, 216);
            this.chkAllowCyberwareESSDiscounts.Name = "chkAllowCyberwareESSDiscounts";
            this.chkAllowCyberwareESSDiscounts.Size = new System.Drawing.Size(279, 17);
            this.chkAllowCyberwareESSDiscounts.TabIndex = 19;
            this.chkAllowCyberwareESSDiscounts.Tag = "Checkbox_Options_AllowCyberwareESSDiscounts";
            this.chkAllowCyberwareESSDiscounts.Text = "Allow Cyber/Bioware Essence costs to be customized";
            this.chkAllowCyberwareESSDiscounts.UseVisualStyleBackColor = true;
            this.chkAllowCyberwareESSDiscounts.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkMysAdPp
            // 
            this.chkMysAdPp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkMysAdPp.AutoSize = true;
            this.chkMysAdPp.DefaultColorScheme = true;
            this.chkMysAdPp.Location = new System.Drawing.Point(3, 334);
            this.chkMysAdPp.Name = "chkMysAdPp";
            this.chkMysAdPp.Size = new System.Drawing.Size(280, 17);
            this.chkMysAdPp.TabIndex = 29;
            this.chkMysAdPp.Tag = "Checkbox_Option_AllowMysadPowerPointCareer";
            this.chkMysAdPp.Text = "Allow Mystic Adepts to buy power points during career";
            this.chkMysAdPp.UseVisualStyleBackColor = true;
            this.chkMysAdPp.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkESSLossReducesMaximumOnly
            // 
            this.chkESSLossReducesMaximumOnly.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkESSLossReducesMaximumOnly.AutoSize = true;
            this.chkESSLossReducesMaximumOnly.DefaultColorScheme = true;
            this.chkESSLossReducesMaximumOnly.Location = new System.Drawing.Point(3, 239);
            this.chkESSLossReducesMaximumOnly.Name = "chkESSLossReducesMaximumOnly";
            this.chkESSLossReducesMaximumOnly.Size = new System.Drawing.Size(251, 17);
            this.chkESSLossReducesMaximumOnly.TabIndex = 20;
            this.chkESSLossReducesMaximumOnly.Tag = "Checkbox_Options_EssenceLossReducesMaximum";
            this.chkESSLossReducesMaximumOnly.Text = "Essence Loss only Reduces Maximum Essence";
            this.chkESSLossReducesMaximumOnly.UseVisualStyleBackColor = true;
            this.chkESSLossReducesMaximumOnly.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkAlternateMetatypeAttributeKarma
            // 
            this.chkAlternateMetatypeAttributeKarma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAlternateMetatypeAttributeKarma.AutoSize = true;
            this.chkAlternateMetatypeAttributeKarma.DefaultColorScheme = true;
            this.chkAlternateMetatypeAttributeKarma.Location = new System.Drawing.Point(3, 311);
            this.chkAlternateMetatypeAttributeKarma.Name = "chkAlternateMetatypeAttributeKarma";
            this.chkAlternateMetatypeAttributeKarma.Size = new System.Drawing.Size(411, 17);
            this.chkAlternateMetatypeAttributeKarma.TabIndex = 28;
            this.chkAlternateMetatypeAttributeKarma.Tag = "Checkbox_Option_AlternateMetatypeAttributeKarma";
            this.chkAlternateMetatypeAttributeKarma.Text = "Treat Metatype Attribute Minimum as 1 for the purpose of determining Karma costs";
            this.chkAlternateMetatypeAttributeKarma.UseVisualStyleBackColor = true;
            this.chkAlternateMetatypeAttributeKarma.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkUseCalculatedPublicAwareness
            // 
            this.chkUseCalculatedPublicAwareness.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkUseCalculatedPublicAwareness.AutoSize = true;
            this.chkUseCalculatedPublicAwareness.DefaultColorScheme = true;
            this.chkUseCalculatedPublicAwareness.Location = new System.Drawing.Point(3, 262);
            this.chkUseCalculatedPublicAwareness.Name = "chkUseCalculatedPublicAwareness";
            this.chkUseCalculatedPublicAwareness.Size = new System.Drawing.Size(289, 17);
            this.chkUseCalculatedPublicAwareness.TabIndex = 22;
            this.chkUseCalculatedPublicAwareness.Tag = "Checkbox_Options_UseCalculatedPublicAwareness";
            this.chkUseCalculatedPublicAwareness.Text = "Public Awareness should be (Street Cred + Notoriety /3)";
            this.chkUseCalculatedPublicAwareness.UseVisualStyleBackColor = true;
            this.chkUseCalculatedPublicAwareness.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkUseTotalValueForFreeContacts
            // 
            this.chkUseTotalValueForFreeContacts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkUseTotalValueForFreeContacts.AutoSize = true;
            this.chkUseTotalValueForFreeContacts.DefaultColorScheme = true;
            this.chkUseTotalValueForFreeContacts.Location = new System.Drawing.Point(610, 29);
            this.chkUseTotalValueForFreeContacts.Name = "chkUseTotalValueForFreeContacts";
            this.chkUseTotalValueForFreeContacts.Size = new System.Drawing.Size(261, 17);
            this.chkUseTotalValueForFreeContacts.TabIndex = 23;
            this.chkUseTotalValueForFreeContacts.Tag = "Checkbox_Options_UseTotalValueForFreeContacts";
            this.chkUseTotalValueForFreeContacts.Text = "Free Contacts use the augmented Charisma value";
            this.chkUseTotalValueForFreeContacts.UseVisualStyleBackColor = true;
            this.chkUseTotalValueForFreeContacts.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkIgnoreComplexFormLimit
            // 
            this.chkIgnoreComplexFormLimit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkIgnoreComplexFormLimit.AutoSize = true;
            this.chkIgnoreComplexFormLimit.DefaultColorScheme = true;
            this.chkIgnoreComplexFormLimit.Location = new System.Drawing.Point(610, 380);
            this.chkIgnoreComplexFormLimit.Name = "chkIgnoreComplexFormLimit";
            this.chkIgnoreComplexFormLimit.Size = new System.Drawing.Size(215, 17);
            this.chkIgnoreComplexFormLimit.TabIndex = 43;
            this.chkIgnoreComplexFormLimit.Tag = "Checkbox_Options_IgnoreComplexFormLimit";
            this.chkIgnoreComplexFormLimit.Text = "Ignore complex form limit in Career mode";
            this.chkIgnoreComplexFormLimit.UseVisualStyleBackColor = true;
            this.chkIgnoreComplexFormLimit.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkSpecialKarmaCost
            // 
            this.chkSpecialKarmaCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSpecialKarmaCost.AutoSize = true;
            this.chkSpecialKarmaCost.DefaultColorScheme = true;
            this.chkSpecialKarmaCost.Location = new System.Drawing.Point(610, 357);
            this.chkSpecialKarmaCost.Name = "chkSpecialKarmaCost";
            this.chkSpecialKarmaCost.Size = new System.Drawing.Size(373, 17);
            this.chkSpecialKarmaCost.TabIndex = 42;
            this.chkSpecialKarmaCost.Tag = "Checkbox_Options_SpecialKarmaCost";
            this.chkSpecialKarmaCost.Text = "Karma cost for increasing Special Attributes is reduced with Essence Loss";
            this.chkSpecialKarmaCost.UseVisualStyleBackColor = true;
            this.chkSpecialKarmaCost.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkMoreLethalGameplay
            // 
            this.chkMoreLethalGameplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkMoreLethalGameplay.AutoSize = true;
            this.chkMoreLethalGameplay.DefaultColorScheme = true;
            this.chkMoreLethalGameplay.Location = new System.Drawing.Point(610, 286);
            this.chkMoreLethalGameplay.Name = "chkMoreLethalGameplay";
            this.chkMoreLethalGameplay.Size = new System.Drawing.Size(297, 17);
            this.chkMoreLethalGameplay.TabIndex = 41;
            this.chkMoreLethalGameplay.Tag = "Checkbox_Options_MoreLethalGameplace";
            this.chkMoreLethalGameplay.Text = "Use 4th Edition Rules for More Lethal Gameplay (SR4 75)";
            this.chkMoreLethalGameplay.UseVisualStyleBackColor = true;
            this.chkMoreLethalGameplay.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkExtendAnyDetectionSpell
            // 
            this.chkExtendAnyDetectionSpell.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkExtendAnyDetectionSpell.AutoSize = true;
            this.chkExtendAnyDetectionSpell.DefaultColorScheme = true;
            this.chkExtendAnyDetectionSpell.Location = new System.Drawing.Point(610, 262);
            this.chkExtendAnyDetectionSpell.Name = "chkExtendAnyDetectionSpell";
            this.chkExtendAnyDetectionSpell.Size = new System.Drawing.Size(332, 17);
            this.chkExtendAnyDetectionSpell.TabIndex = 40;
            this.chkExtendAnyDetectionSpell.Tag = "Checkbox_Options_ExtendAnyDetectionSpell";
            this.chkExtendAnyDetectionSpell.Text = "Allow any Detection Spell to be taken as Extended range version";
            this.chkExtendAnyDetectionSpell.UseVisualStyleBackColor = true;
            this.chkExtendAnyDetectionSpell.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkAllowSkillRegrouping
            // 
            this.chkAllowSkillRegrouping.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAllowSkillRegrouping.AutoSize = true;
            this.chkAllowSkillRegrouping.DefaultColorScheme = true;
            this.chkAllowSkillRegrouping.Location = new System.Drawing.Point(610, 216);
            this.chkAllowSkillRegrouping.Name = "chkAllowSkillRegrouping";
            this.chkAllowSkillRegrouping.Size = new System.Drawing.Size(285, 17);
            this.chkAllowSkillRegrouping.TabIndex = 39;
            this.chkAllowSkillRegrouping.Tag = "Checkbox_Options_SkillRegroup";
            this.chkAllowSkillRegrouping.Text = "Allow Skills to be re-Grouped if all Ratings are the same";
            this.chkAllowSkillRegrouping.UseVisualStyleBackColor = true;
            this.chkAllowSkillRegrouping.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkNoArmorEncumbrance
            // 
            this.chkNoArmorEncumbrance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkNoArmorEncumbrance.AutoSize = true;
            this.chkNoArmorEncumbrance.DefaultColorScheme = true;
            this.chkNoArmorEncumbrance.Location = new System.Drawing.Point(610, 239);
            this.chkNoArmorEncumbrance.Name = "chkNoArmorEncumbrance";
            this.chkNoArmorEncumbrance.Size = new System.Drawing.Size(139, 17);
            this.chkNoArmorEncumbrance.TabIndex = 38;
            this.chkNoArmorEncumbrance.Tag = "Checkbox_Options_NoArmorEncumbrance";
            this.chkNoArmorEncumbrance.Text = "No Armor Encumbrance";
            this.chkNoArmorEncumbrance.UseVisualStyleBackColor = true;
            this.chkNoArmorEncumbrance.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkIncreasedImprovedAbilityModifier
            // 
            this.chkIncreasedImprovedAbilityModifier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkIncreasedImprovedAbilityModifier.AutoSize = true;
            this.chkIncreasedImprovedAbilityModifier.DefaultColorScheme = true;
            this.chkIncreasedImprovedAbilityModifier.Location = new System.Drawing.Point(610, 334);
            this.chkIncreasedImprovedAbilityModifier.Name = "chkIncreasedImprovedAbilityModifier";
            this.chkIncreasedImprovedAbilityModifier.Size = new System.Drawing.Size(332, 17);
            this.chkIncreasedImprovedAbilityModifier.TabIndex = 44;
            this.chkIncreasedImprovedAbilityModifier.Tag = "Checkbox_Options_IncreasedImprovedAbilityModifier";
            this.chkIncreasedImprovedAbilityModifier.Text = "Improved Ability is capped by Learned Rating x 1.5 instead of 0.5";
            this.chkIncreasedImprovedAbilityModifier.UseVisualStyleBackColor = true;
            this.chkIncreasedImprovedAbilityModifier.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkAllowFreeGrids
            // 
            this.chkAllowFreeGrids.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAllowFreeGrids.AutoSize = true;
            this.chkAllowFreeGrids.DefaultColorScheme = true;
            this.chkAllowFreeGrids.Location = new System.Drawing.Point(610, 311);
            this.chkAllowFreeGrids.Name = "chkAllowFreeGrids";
            this.chkAllowFreeGrids.Size = new System.Drawing.Size(460, 17);
            this.chkAllowFreeGrids.TabIndex = 45;
            this.chkAllowFreeGrids.Tag = "Checkbox_Options_AllowFreeGrids";
            this.chkAllowFreeGrids.Text = "Allow Free Grid Subscription Qualities for lifestyles even if Hard Targets is not" +
    " an active book";
            this.chkAllowFreeGrids.UseVisualStyleBackColor = true;
            this.chkAllowFreeGrids.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkAllowTechnomancerSchooling
            // 
            this.chkAllowTechnomancerSchooling.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAllowTechnomancerSchooling.AutoSize = true;
            this.chkAllowTechnomancerSchooling.DefaultColorScheme = true;
            this.chkAllowTechnomancerSchooling.Location = new System.Drawing.Point(3, 193);
            this.chkAllowTechnomancerSchooling.Name = "chkAllowTechnomancerSchooling";
            this.chkAllowTechnomancerSchooling.Size = new System.Drawing.Size(273, 17);
            this.chkAllowTechnomancerSchooling.TabIndex = 45;
            this.chkAllowTechnomancerSchooling.Tag = "Checkbox_Options_AllowTechnomancerSchooling";
            this.chkAllowTechnomancerSchooling.Text = "Technomancer: Allow \'Schooling\' Initiation discounts";
            this.chkAllowTechnomancerSchooling.UseVisualStyleBackColor = true;
            this.chkAllowTechnomancerSchooling.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkUsePointsOnBrokenGroups
            // 
            this.chkUsePointsOnBrokenGroups.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkUsePointsOnBrokenGroups.AutoSize = true;
            this.chkUsePointsOnBrokenGroups.DefaultColorScheme = true;
            this.chkUsePointsOnBrokenGroups.Location = new System.Drawing.Point(3, 147);
            this.chkUsePointsOnBrokenGroups.Name = "chkUsePointsOnBrokenGroups";
            this.chkUsePointsOnBrokenGroups.Size = new System.Drawing.Size(185, 17);
            this.chkUsePointsOnBrokenGroups.TabIndex = 49;
            this.chkUsePointsOnBrokenGroups.Tag = "Checkbox_Options_PointsOnBrokenGroups";
            this.chkUsePointsOnBrokenGroups.Text = "Use Skill Points on broken groups";
            this.chkUsePointsOnBrokenGroups.UseVisualStyleBackColor = true;
            this.chkUsePointsOnBrokenGroups.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // flpDroneArmorMultiplier
            // 
            this.flpDroneArmorMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flpDroneArmorMultiplier.AutoSize = true;
            this.flpDroneArmorMultiplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpDroneArmorMultiplier.Controls.Add(this.chkDroneArmorMultiplier);
            this.flpDroneArmorMultiplier.Controls.Add(this.label4);
            this.flpDroneArmorMultiplier.Controls.Add(this.nudDroneArmorMultiplier);
            this.flpDroneArmorMultiplier.Location = new System.Drawing.Point(0, 282);
            this.flpDroneArmorMultiplier.Margin = new System.Windows.Forms.Padding(0);
            this.flpDroneArmorMultiplier.Name = "flpDroneArmorMultiplier";
            this.flpDroneArmorMultiplier.Size = new System.Drawing.Size(317, 26);
            this.flpDroneArmorMultiplier.TabIndex = 51;
            this.flpDroneArmorMultiplier.WrapContents = false;
            // 
            // chkDroneArmorMultiplier
            // 
            this.chkDroneArmorMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkDroneArmorMultiplier.AutoSize = true;
            this.chkDroneArmorMultiplier.DefaultColorScheme = true;
            this.chkDroneArmorMultiplier.Location = new System.Drawing.Point(3, 4);
            this.chkDroneArmorMultiplier.Name = "chkDroneArmorMultiplier";
            this.chkDroneArmorMultiplier.Size = new System.Drawing.Size(252, 17);
            this.chkDroneArmorMultiplier.TabIndex = 25;
            this.chkDroneArmorMultiplier.Tag = "Checkbox_Options_DroneArmorMultiplier";
            this.chkDroneArmorMultiplier.Text = "Limit Drone Armor Enhance ment to Drone Body";
            this.chkDroneArmorMultiplier.UseVisualStyleBackColor = true;
            this.chkDroneArmorMultiplier.CheckedChanged += new System.EventHandler(this.chkDroneArmorMultiplier_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "x";
            // 
            // nudDroneArmorMultiplier
            // 
            this.nudDroneArmorMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudDroneArmorMultiplier.AutoSize = true;
            this.nudDroneArmorMultiplier.Enabled = false;
            this.nudDroneArmorMultiplier.Location = new System.Drawing.Point(279, 3);
            this.nudDroneArmorMultiplier.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDroneArmorMultiplier.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDroneArmorMultiplier.Name = "nudDroneArmorMultiplier";
            this.nudDroneArmorMultiplier.Size = new System.Drawing.Size(35, 20);
            this.nudDroneArmorMultiplier.TabIndex = 26;
            this.nudDroneArmorMultiplier.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDroneArmorMultiplier.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // flpContactMultiplier
            // 
            this.flpContactMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flpContactMultiplier.AutoSize = true;
            this.flpContactMultiplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpContactMultiplier.Controls.Add(this.chkContactMultiplier);
            this.flpContactMultiplier.Controls.Add(this.label2);
            this.flpContactMultiplier.Controls.Add(this.nudContactMultiplier);
            this.flpContactMultiplier.Location = new System.Drawing.Point(607, 0);
            this.flpContactMultiplier.Margin = new System.Windows.Forms.Padding(0);
            this.flpContactMultiplier.Name = "flpContactMultiplier";
            this.flpContactMultiplier.Size = new System.Drawing.Size(293, 26);
            this.flpContactMultiplier.TabIndex = 52;
            this.flpContactMultiplier.WrapContents = false;
            // 
            // chkContactMultiplier
            // 
            this.chkContactMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkContactMultiplier.AutoSize = true;
            this.chkContactMultiplier.DefaultColorScheme = true;
            this.chkContactMultiplier.Location = new System.Drawing.Point(3, 4);
            this.chkContactMultiplier.Name = "chkContactMultiplier";
            this.chkContactMultiplier.Size = new System.Drawing.Size(228, 17);
            this.chkContactMultiplier.TabIndex = 9;
            this.chkContactMultiplier.Tag = "Checkbox_Options_ContactMultiplier";
            this.chkContactMultiplier.Text = "Override Contact Points Charisma Multiplier";
            this.chkContactMultiplier.UseVisualStyleBackColor = true;
            this.chkContactMultiplier.CheckedChanged += new System.EventHandler(this.chkContactMultiplier_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "x";
            // 
            // nudContactMultiplier
            // 
            this.nudContactMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudContactMultiplier.AutoSize = true;
            this.nudContactMultiplier.Enabled = false;
            this.nudContactMultiplier.Location = new System.Drawing.Point(255, 3);
            this.nudContactMultiplier.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudContactMultiplier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudContactMultiplier.Name = "nudContactMultiplier";
            this.nudContactMultiplier.Size = new System.Drawing.Size(35, 20);
            this.nudContactMultiplier.TabIndex = 11;
            this.nudContactMultiplier.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudContactMultiplier.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // flpKnowledgeMultiplier
            // 
            this.flpKnowledgeMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flpKnowledgeMultiplier.AutoSize = true;
            this.flpKnowledgeMultiplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpKnowledgeMultiplier.Controls.Add(this.chkKnowledgeMultiplier);
            this.flpKnowledgeMultiplier.Controls.Add(this.label3);
            this.flpKnowledgeMultiplier.Controls.Add(this.nudKnowledgeMultiplier);
            this.flpKnowledgeMultiplier.Location = new System.Drawing.Point(607, 49);
            this.flpKnowledgeMultiplier.Margin = new System.Windows.Forms.Padding(0);
            this.flpKnowledgeMultiplier.Name = "flpKnowledgeMultiplier";
            this.flpKnowledgeMultiplier.Size = new System.Drawing.Size(324, 26);
            this.flpKnowledgeMultiplier.TabIndex = 53;
            // 
            // chkKnowledgeMultiplier
            // 
            this.chkKnowledgeMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkKnowledgeMultiplier.AutoSize = true;
            this.chkKnowledgeMultiplier.DefaultColorScheme = true;
            this.chkKnowledgeMultiplier.Location = new System.Drawing.Point(3, 4);
            this.chkKnowledgeMultiplier.Name = "chkKnowledgeMultiplier";
            this.chkKnowledgeMultiplier.Size = new System.Drawing.Size(259, 17);
            this.chkKnowledgeMultiplier.TabIndex = 12;
            this.chkKnowledgeMultiplier.Tag = "Checkbox_Options_KnowledgeMultiplier";
            this.chkKnowledgeMultiplier.Text = "Override Knowledge Points (INT + LOG) Multiplier";
            this.chkKnowledgeMultiplier.UseVisualStyleBackColor = true;
            this.chkKnowledgeMultiplier.CheckedChanged += new System.EventHandler(this.chkKnowledgeMultiplier_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "x";
            // 
            // nudKnowledgeMultiplier
            // 
            this.nudKnowledgeMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudKnowledgeMultiplier.AutoSize = true;
            this.nudKnowledgeMultiplier.Enabled = false;
            this.nudKnowledgeMultiplier.Location = new System.Drawing.Point(286, 3);
            this.nudKnowledgeMultiplier.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudKnowledgeMultiplier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKnowledgeMultiplier.Name = "nudKnowledgeMultiplier";
            this.nudKnowledgeMultiplier.Size = new System.Drawing.Size(35, 20);
            this.nudKnowledgeMultiplier.TabIndex = 14;
            this.nudKnowledgeMultiplier.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudKnowledgeMultiplier.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // flpCyberlimbAttributeBonusCap
            // 
            this.flpCyberlimbAttributeBonusCap.AutoSize = true;
            this.flpCyberlimbAttributeBonusCap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpCyberlimbAttributeBonusCap.Controls.Add(this.chkCyberlimbAttributeBonusCap);
            this.flpCyberlimbAttributeBonusCap.Controls.Add(this.label1);
            this.flpCyberlimbAttributeBonusCap.Controls.Add(this.nudCyberlimbAttributeBonusCap);
            this.flpCyberlimbAttributeBonusCap.Location = new System.Drawing.Point(607, 400);
            this.flpCyberlimbAttributeBonusCap.Margin = new System.Windows.Forms.Padding(0);
            this.flpCyberlimbAttributeBonusCap.Name = "flpCyberlimbAttributeBonusCap";
            this.flpCyberlimbAttributeBonusCap.Size = new System.Drawing.Size(305, 26);
            this.flpCyberlimbAttributeBonusCap.TabIndex = 54;
            // 
            // chkCyberlimbAttributeBonusCap
            // 
            this.chkCyberlimbAttributeBonusCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkCyberlimbAttributeBonusCap.AutoSize = true;
            this.chkCyberlimbAttributeBonusCap.DefaultColorScheme = true;
            this.chkCyberlimbAttributeBonusCap.Location = new System.Drawing.Point(3, 4);
            this.chkCyberlimbAttributeBonusCap.Name = "chkCyberlimbAttributeBonusCap";
            this.chkCyberlimbAttributeBonusCap.Size = new System.Drawing.Size(234, 17);
            this.chkCyberlimbAttributeBonusCap.TabIndex = 46;
            this.chkCyberlimbAttributeBonusCap.Tag = "Checkbox_Options_CyberlimbAttributeBonusCap";
            this.chkCyberlimbAttributeBonusCap.Text = "Override maximum Bonus cap for Cyberlimbs";
            this.chkCyberlimbAttributeBonusCap.UseVisualStyleBackColor = true;
            this.chkCyberlimbAttributeBonusCap.CheckedChanged += new System.EventHandler(this.chkCyberlimbAttributeBonusCap_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "x";
            // 
            // nudCyberlimbAttributeBonusCap
            // 
            this.nudCyberlimbAttributeBonusCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudCyberlimbAttributeBonusCap.AutoSize = true;
            this.nudCyberlimbAttributeBonusCap.Enabled = false;
            this.nudCyberlimbAttributeBonusCap.Location = new System.Drawing.Point(261, 3);
            this.nudCyberlimbAttributeBonusCap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCyberlimbAttributeBonusCap.Name = "nudCyberlimbAttributeBonusCap";
            this.nudCyberlimbAttributeBonusCap.Size = new System.Drawing.Size(41, 20);
            this.nudCyberlimbAttributeBonusCap.TabIndex = 48;
            this.nudCyberlimbAttributeBonusCap.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCyberlimbAttributeBonusCap.ValueChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkUnclampAttributeMinimum
            // 
            this.chkUnclampAttributeMinimum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkUnclampAttributeMinimum.AutoSize = true;
            this.chkUnclampAttributeMinimum.DefaultColorScheme = true;
            this.chkUnclampAttributeMinimum.Location = new System.Drawing.Point(610, 429);
            this.chkUnclampAttributeMinimum.Name = "chkUnclampAttributeMinimum";
            this.chkUnclampAttributeMinimum.Size = new System.Drawing.Size(328, 17);
            this.chkUnclampAttributeMinimum.TabIndex = 50;
            this.chkUnclampAttributeMinimum.Tag = "Checkbox_Options_UnclampAttributeMinimum";
            this.chkUnclampAttributeMinimum.Text = "Attribute values are allowed to go below 0 due to Essence Loss.";
            this.chkUnclampAttributeMinimum.UseVisualStyleBackColor = true;
            this.chkUnclampAttributeMinimum.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // chkEnemyKarmaQualityLimit
            // 
            this.chkEnemyKarmaQualityLimit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkEnemyKarmaQualityLimit.AutoSize = true;
            this.chkEnemyKarmaQualityLimit.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkEnemyKarmaQualityLimit.DefaultColorScheme = true;
            this.chkEnemyKarmaQualityLimit.Location = new System.Drawing.Point(610, 193);
            this.chkEnemyKarmaQualityLimit.Name = "chkEnemyKarmaQualityLimit";
            this.chkEnemyKarmaQualityLimit.Size = new System.Drawing.Size(389, 17);
            this.chkEnemyKarmaQualityLimit.TabIndex = 37;
            this.chkEnemyKarmaQualityLimit.Tag = "Checkbox_Options_EnemyKarmaQualityLimit";
            this.chkEnemyKarmaQualityLimit.Text = "Karma spent on enemies counts towards negative Quality limit in create mode";
            this.chkEnemyKarmaQualityLimit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkEnemyKarmaQualityLimit.UseVisualStyleBackColor = true;
            // 
            // chkCompensateSkillGroupKarmaDifference
            // 
            this.chkCompensateSkillGroupKarmaDifference.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkCompensateSkillGroupKarmaDifference.AutoSize = true;
            this.chkCompensateSkillGroupKarmaDifference.DefaultColorScheme = true;
            this.chkCompensateSkillGroupKarmaDifference.Location = new System.Drawing.Point(610, 452);
            this.chkCompensateSkillGroupKarmaDifference.Name = "chkCompensateSkillGroupKarmaDifference";
            this.chkCompensateSkillGroupKarmaDifference.Size = new System.Drawing.Size(440, 17);
            this.chkCompensateSkillGroupKarmaDifference.TabIndex = 36;
            this.chkCompensateSkillGroupKarmaDifference.Tag = "Checkbox_Options_CompensateSkillGroupKarmaDifference";
            this.chkCompensateSkillGroupKarmaDifference.Text = "Compensate for higher karma costs when raising the rating of the last skill in a " +
    "skill group";
            this.chkCompensateSkillGroupKarmaDifference.UseVisualStyleBackColor = true;
            // 
            // tabGitHubIssues
            // 
            this.tabGitHubIssues.BackColor = System.Drawing.SystemColors.Control;
            this.tabGitHubIssues.Controls.Add(this.cmdUploadPastebin);
            this.tabGitHubIssues.Location = new System.Drawing.Point(4, 22);
            this.tabGitHubIssues.Name = "tabGitHubIssues";
            this.tabGitHubIssues.Padding = new System.Windows.Forms.Padding(3);
            this.tabGitHubIssues.Size = new System.Drawing.Size(1232, 568);
            this.tabGitHubIssues.TabIndex = 4;
            this.tabGitHubIssues.Tag = "Tab_Options_GitHubIssues";
            this.tabGitHubIssues.Text = "GitHub Issues";
            // 
            // cmdUploadPastebin
            // 
            this.cmdUploadPastebin.AutoSize = true;
            this.cmdUploadPastebin.Enabled = false;
            this.cmdUploadPastebin.Location = new System.Drawing.Point(6, 6);
            this.cmdUploadPastebin.Name = "cmdUploadPastebin";
            this.cmdUploadPastebin.Size = new System.Drawing.Size(178, 30);
            this.cmdUploadPastebin.TabIndex = 1;
            this.cmdUploadPastebin.Tag = "Button_Options_UploadPastebin";
            this.cmdUploadPastebin.Text = "Upload file to Pastebin";
            this.cmdUploadPastebin.UseVisualStyleBackColor = true;
            this.cmdUploadPastebin.Click += new System.EventHandler(this.cmdUploadPastebin_Click);
            // 
            // tabPlugins
            // 
            this.tabPlugins.BackColor = System.Drawing.SystemColors.Control;
            this.tabPlugins.Controls.Add(this.tlpPlugins);
            this.tabPlugins.Location = new System.Drawing.Point(4, 22);
            this.tabPlugins.Name = "tabPlugins";
            this.tabPlugins.Padding = new System.Windows.Forms.Padding(9);
            this.tabPlugins.Size = new System.Drawing.Size(1232, 568);
            this.tabPlugins.TabIndex = 6;
            this.tabPlugins.Tag = "Tab_Options_Plugins";
            this.tabPlugins.Text = "Plugins";
            // 
            // tlpPlugins
            // 
            this.tlpPlugins.AutoSize = true;
            this.tlpPlugins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpPlugins.ColumnCount = 2;
            this.tlpPlugins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPlugins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlugins.Controls.Add(this.grpAvailablePlugins, 0, 0);
            this.tlpPlugins.Controls.Add(this.panelPluginOption, 1, 0);
            this.tlpPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlugins.Location = new System.Drawing.Point(9, 9);
            this.tlpPlugins.MinimumSize = new System.Drawing.Size(823, 516);
            this.tlpPlugins.Name = "tlpPlugins";
            this.tlpPlugins.RowCount = 1;
            this.tlpPlugins.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlugins.Size = new System.Drawing.Size(1214, 550);
            this.tlpPlugins.TabIndex = 0;
            // 
            // grpAvailablePlugins
            // 
            this.grpAvailablePlugins.Controls.Add(this.clbPlugins);
            this.grpAvailablePlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAvailablePlugins.Location = new System.Drawing.Point(3, 3);
            this.grpAvailablePlugins.Name = "grpAvailablePlugins";
            this.grpAvailablePlugins.Size = new System.Drawing.Size(295, 544);
            this.grpAvailablePlugins.TabIndex = 0;
            this.grpAvailablePlugins.TabStop = false;
            this.grpAvailablePlugins.Tag = "String_AvailablePlugins";
            this.grpAvailablePlugins.Text = "Available Plugins";
            // 
            // clbPlugins
            // 
            this.clbPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbPlugins.FormattingEnabled = true;
            this.clbPlugins.Location = new System.Drawing.Point(3, 16);
            this.clbPlugins.Name = "clbPlugins";
            this.clbPlugins.Size = new System.Drawing.Size(289, 525);
            this.clbPlugins.TabIndex = 0;
            this.clbPlugins.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbPlugins_ItemCheck);
            this.clbPlugins.SelectedValueChanged += new System.EventHandler(this.clbPlugins_SelectedValueChanged);
            this.clbPlugins.VisibleChanged += new System.EventHandler(this.clbPlugins_VisibleChanged);
            // 
            // panelPluginOption
            // 
            this.panelPluginOption.AutoScroll = true;
            this.panelPluginOption.AutoSize = true;
            this.panelPluginOption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPluginOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPluginOption.Location = new System.Drawing.Point(301, 0);
            this.panelPluginOption.Margin = new System.Windows.Forms.Padding(0);
            this.panelPluginOption.Name = "panelPluginOption";
            this.panelPluginOption.Size = new System.Drawing.Size(913, 550);
            this.panelPluginOption.TabIndex = 1;
            // 
            // flpOKCancel
            // 
            this.flpOKCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flpOKCancel.AutoSize = true;
            this.tlpOptions.SetColumnSpan(this.flpOKCancel, 4);
            this.flpOKCancel.Controls.Add(this.cmdOK);
            this.flpOKCancel.Controls.Add(this.cmdCancel);
            this.flpOKCancel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpOKCancel.Location = new System.Drawing.Point(1077, 630);
            this.flpOKCancel.Name = "flpOKCancel";
            this.flpOKCancel.Size = new System.Drawing.Size(166, 30);
            this.flpOKCancel.TabIndex = 5;
            // 
            // cmdOK
            // 
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdOK.Location = new System.Drawing.Point(86, 0);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(80, 30);
            this.cmdOK.TabIndex = 5;
            this.cmdOK.Tag = "String_OK";
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.AutoSize = true;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(0, 0);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(80, 30);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Tag = "String_Cancel";
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tlpOptions);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Title_Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.tlpOptions.ResumeLayout(false);
            this.tlpOptions.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.tabGlobal.ResumeLayout(false);
            this.tabGlobal.PerformLayout();
            this.tlpGlobal.ResumeLayout(false);
            this.tlpGlobal.PerformLayout();
            this.grpSelectedSourcebook.ResumeLayout(false);
            this.grpSelectedSourcebook.PerformLayout();
            this.tlpSelectedSourcebook.ResumeLayout(false);
            this.tlpSelectedSourcebook.PerformLayout();
            this.flpPDFOffset.ResumeLayout(false);
            this.flpPDFOffset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPDFOffset)).EndInit();
            this.tlpGlobalOptions.ResumeLayout(false);
            this.tlpGlobalOptions.PerformLayout();
            this.grpTimeFormat.ResumeLayout(false);
            this.grpTimeFormat.PerformLayout();
            this.bufferedTableLayoutPanel3.ResumeLayout(false);
            this.bufferedTableLayoutPanel3.PerformLayout();
            this.grpCharacterDefaults.ResumeLayout(false);
            this.grpCharacterDefaults.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLanguageFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSheetLanguageFlag)).EndInit();
            this.flpUseLogging.ResumeLayout(false);
            this.flpUseLogging.PerformLayout();
            this.flpEnablePlugins.ResumeLayout(false);
            this.flpEnablePlugins.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.grpDateFormat.ResumeLayout(false);
            this.grpDateFormat.PerformLayout();
            this.bufferedTableLayoutPanel2.ResumeLayout(false);
            this.bufferedTableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrowserVersion)).EndInit();
            this.flpMugshotCompressionQuality.ResumeLayout(false);
            this.flpMugshotCompressionQuality.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMugshotCompressionQuality)).EndInit();
            this.tlpColorMode.ResumeLayout(false);
            this.tlpColorMode.PerformLayout();
            this.gpbEditSourcebookInfo.ResumeLayout(false);
            this.tabCharacterOptions.ResumeLayout(false);
            this.tabCharacterOptions.PerformLayout();
            this.tlpCharacterOptions.ResumeLayout(false);
            this.tlpCharacterOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNuyenDecimalsMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNuyenDecimalsMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEssenceDecimals)).EndInit();
            this.gpbSourcebook.ResumeLayout(false);
            this.tabKarmaCosts.ResumeLayout(false);
            this.tlpKarmaCosts.ResumeLayout(false);
            this.tlpKarmaCosts.PerformLayout();
            this.tlpKarmaCostsList.ResumeLayout(false);
            this.tlpKarmaCostsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaNuyenPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaImproveKnowledgeSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaImproveActiveSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaImproveSkillGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaAttribute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaAlchemicalFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaBanishingFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaBindingFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaCenteringFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaCounterspellingFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaDisenchantingFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaFlexibleSignatureFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaMaskingFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaPowerFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaQiFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaRitualSpellcastingFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaSpellcastingFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaSummoningFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaSustainingFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaSpellShapingFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaWeaponFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMetatypeCostsKarmaMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaNewAIAdvancedProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaNewAIProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaTechnique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaNewComplexForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaSpell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaLeaveGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaJoinGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaMetamagic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaSpecialization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaKnowledgeSpecialization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaNewKnowledgeSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaNewActiveSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaNewSkillGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNuyenPerBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaCarryover)).EndInit();
            this.flpKarmaInitiation.ResumeLayout(false);
            this.flpKarmaInitiation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaInitiation)).EndInit();
            this.flpKarmaInitiationExtra.ResumeLayout(false);
            this.flpKarmaInitiationExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaInitiationFlat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaSpirit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarmaMysticAdeptPowerPoint)).EndInit();
            this.tabOptionalRules.ResumeLayout(false);
            this.tabOptionalRules.PerformLayout();
            this.tlpOptionalRules.ResumeLayout(false);
            this.tlpOptionalRules.PerformLayout();
            this.tabHouseRules.ResumeLayout(false);
            this.tlpHouseRules.ResumeLayout(false);
            this.tlpHouseRules.PerformLayout();
            this.flpDroneArmorMultiplier.ResumeLayout(false);
            this.flpDroneArmorMultiplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDroneArmorMultiplier)).EndInit();
            this.flpContactMultiplier.ResumeLayout(false);
            this.flpContactMultiplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContactMultiplier)).EndInit();
            this.flpKnowledgeMultiplier.ResumeLayout(false);
            this.flpKnowledgeMultiplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKnowledgeMultiplier)).EndInit();
            this.flpCyberlimbAttributeBonusCap.ResumeLayout(false);
            this.flpCyberlimbAttributeBonusCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCyberlimbAttributeBonusCap)).EndInit();
            this.tabGitHubIssues.ResumeLayout(false);
            this.tabGitHubIssues.PerformLayout();
            this.tabPlugins.ResumeLayout(false);
            this.tabPlugins.PerformLayout();
            this.tlpPlugins.ResumeLayout(false);
            this.tlpPlugins.PerformLayout();
            this.grpAvailablePlugins.ResumeLayout(false);
            this.flpOKCancel.ResumeLayout(false);
            this.flpOKCancel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BufferedTableLayoutPanel tlpOptions;
        private System.Windows.Forms.TextBox txtSettingName;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.Label lblSettingName;
        private ElasticComboBox cboSetting;
        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tabGlobal;
        private BufferedTableLayoutPanel tlpGlobal;
        private System.Windows.Forms.GroupBox grpSelectedSourcebook;
        private BufferedTableLayoutPanel tlpSelectedSourcebook;
        private System.Windows.Forms.TextBox txtPDFLocation;
        private System.Windows.Forms.Label lblPDFLocation;
        private System.Windows.Forms.Button cmdPDFLocation;
        private System.Windows.Forms.Label lblPDFOffset;
        private System.Windows.Forms.FlowLayoutPanel flpPDFOffset;
        private Chummer.NumericUpDownEx nudPDFOffset;
        private System.Windows.Forms.Button cmdPDFTest;
        private System.Windows.Forms.TableLayoutPanel tlpGlobalOptions;
        private System.Windows.Forms.Label lblPDFAppPath;
        private System.Windows.Forms.Label lblPDFParametersLabel;
        private Chummer.ColorableCheckBox chkHideCharacterRoster;
        private System.Windows.Forms.GroupBox grpTimeFormat;
        private BufferedTableLayoutPanel bufferedTableLayoutPanel3;
        private System.Windows.Forms.TextBox txtTimeFormat;
        private System.Windows.Forms.TextBox txtTimeFormatView;
        private Chummer.ColorableCheckBox chkSearchInCategoryOnly;
        private System.Windows.Forms.Label lblCharacterRosterLabel;
        private Chummer.ColorableCheckBox chkAllowEasterEggs;
        private System.Windows.Forms.GroupBox grpCharacterDefaults;
        private BufferedTableLayoutPanel tableLayoutPanel7;
        private ElasticComboBox cboBuildMethod;
        private System.Windows.Forms.ComboBox cboDefaultGameplayOption;
        private Chummer.ColorableCheckBox chkPrintToFileFirst;
        private Chummer.NumericUpDownEx nudBrowserVersion;
        private Chummer.ColorableCheckBox chkPreferNightlyBuilds;
        private System.Windows.Forms.Label lblBrowserVersion;
        private Chummer.ColorableCheckBox chkLiveUpdateCleanCharacterFiles;
        private System.Windows.Forms.Label lblLanguage;
        private Chummer.ColorableCheckBox chkDatesIncludeTime;
        private Chummer.ColorableCheckBox chkLiveCustomData;
        private Chummer.ColorableCheckBox chkSingleDiceRoller;
        private Chummer.ColorableCheckBox chkStartupFullscreen;
        private System.Windows.Forms.Label lblXSLT;
        private System.Windows.Forms.PictureBox imgLanguageFlag;
        private Chummer.ColorableCheckBox chkLifeModule;
        private Chummer.ColorableCheckBox chkAutomaticUpdate;
        private Chummer.ColorableCheckBox chkAllowHoverIncrement;
        private Chummer.ColorableCheckBox chkUseLogging;
        private System.Windows.Forms.PictureBox imgSheetLanguageFlag;
        private ElasticComboBox cboSheetLanguage;
        private ElasticComboBox cboLanguage;
        private System.Windows.Forms.Button cmdVerify;
        private System.Windows.Forms.Button cmdVerifyData;
        private ElasticComboBox cboXSLT;
        private Chummer.ColorableCheckBox chkCustomDateTimeFormats;
        private Chummer.ColorableCheckBox chkConfirmKarmaExpense;
        private Chummer.ColorableCheckBox chkConfirmDelete;
        private System.Windows.Forms.FlowLayoutPanel flpUseLogging;
        private System.Windows.Forms.ComboBox cboUseLoggingApplicationInsights;
        private ButtonWithToolTip cmdUseLoggingHelp;
        private Chummer.ColorableCheckBox chkHideItemsOverAvail;
        private System.Windows.Forms.FlowLayoutPanel flpEnablePlugins;
        private Chummer.ColorableCheckBox chkEnablePlugins;
        private System.Windows.Forms.Button cmdPluginsHelp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txtCharacterRosterPath;
        private System.Windows.Forms.Button cmdCharacterRoster;
        private ElasticComboBox cboPDFParameters;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox txtPDFAppPath;
        private System.Windows.Forms.Button cmdPDFAppPath;
        private System.Windows.Forms.GroupBox grpDateFormat;
        private BufferedTableLayoutPanel bufferedTableLayoutPanel2;
        private System.Windows.Forms.TextBox txtDateFormat;
        private System.Windows.Forms.TextBox txtDateFormatView;
        private Chummer.ColorableCheckBox chkCreateBackupOnCareer;
        private System.Windows.Forms.Label lblMugshotCompression;
        private System.Windows.Forms.GroupBox gpbEditSourcebookInfo;
        private System.Windows.Forms.ListBox lstGlobalSourcebookInfos;
        private System.Windows.Forms.TabPage tabCharacterOptions;
        private BufferedTableLayoutPanel tlpCharacterOptions;
        private System.Windows.Forms.TreeView treSourcebook;
        private Chummer.ColorableCheckBox chkPrintNotes;
        private Chummer.ColorableCheckBox chkPrintExpenses;
        private Chummer.ColorableCheckBox chkPrintSkillsWithZeroRating;
        private Chummer.ColorableCheckBox chkDontUseCyberlimbCalculation;
        private Chummer.ColorableCheckBox chkAllowSkillDiceRolling;
        private Chummer.ColorableCheckBox chkEnforceCapacity;
        private Chummer.ColorableCheckBox chkLicenseEachRestrictedItem;
        private System.Windows.Forms.Label lblEssenceDecimals;
        private System.Windows.Forms.Label lblNuyenDecimalsMaximumLabel;
        private System.Windows.Forms.Label lblNuyenDecimalsMinimumLabel;
        private Chummer.ColorableCheckBox chkDontRoundEssenceInternally;
        private Chummer.ColorableCheckBox chkDronemods;
        private Chummer.ColorableCheckBox chkRestrictRecoil;
        private Chummer.NumericUpDownEx nudNuyenDecimalsMinimum;
        private Chummer.NumericUpDownEx nudNuyenDecimalsMaximum;
        private Chummer.NumericUpDownEx nudEssenceDecimals;
        private Chummer.ColorableCheckBox chkDronemodsMaximumPilot;
        private Chummer.ColorableCheckBox chkPrintFreeExpenses;
        private System.Windows.Forms.Label lblLimbCount;
        private ElasticComboBox cboLimbCount;
        private System.Windows.Forms.Button cmdEnableSourcebooks;
        private System.Windows.Forms.TabPage tabKarmaCosts;
        private System.Windows.Forms.Button cmdRestoreDefaultsKarma;
        private System.Windows.Forms.TabPage tabOptionalRules;
        private BufferedTableLayoutPanel tlpOptionalRules;
        private System.Windows.Forms.Button cmdDecreaseCustomDirectoryLoadOrder;
        private System.Windows.Forms.Button cmdIncreaseCustomDirectoryLoadOrder;
        private System.Windows.Forms.Label lblCustomDataDirectoriesLabel;
        private System.Windows.Forms.Button cmdAddCustomDirectory;
        private System.Windows.Forms.TreeView treCustomDataDirectories;
        private System.Windows.Forms.Button cmdRenameCustomDataDirectory;
        private System.Windows.Forms.Button cmdRemoveCustomDirectory;
        private System.Windows.Forms.TabPage tabHouseRules;
        private BufferedTableLayoutPanel tlpHouseRules;
        private Chummer.NumericUpDownEx nudCyberlimbAttributeBonusCap;
        private System.Windows.Forms.Label label1;
        private Chummer.ColorableCheckBox chkCyberlimbAttributeBonusCap;
        private Chummer.ColorableCheckBox chkIgnoreArt;
        private Chummer.ColorableCheckBox chkExceedNegativeQualitiesLimit;
        private Chummer.ColorableCheckBox chkUseTotalValueForFreeKnowledge;
        private Chummer.ColorableCheckBox chkExceedNegativeQualities;
        private Chummer.ColorableCheckBox chkEnemyKarmaQualityLimit;
        private Chummer.ColorableCheckBox chkExceedPositiveQualitiesCostDoubled;
        private Chummer.ColorableCheckBox chkExceedPositiveQualities;
        private Chummer.ColorableCheckBox chkUnarmedSkillImprovements;
        private Chummer.ColorableCheckBox chkCompensateSkillGroupKarmaDifference;
        private Chummer.ColorableCheckBox chkCyberlegMovement;
        private Chummer.ColorableCheckBox chkMysAdeptSecondMAGAttribute;
        private Chummer.ColorableCheckBox chkDontDoubleQualityPurchases;
        private Chummer.ColorableCheckBox chkAllowPointBuySpecializationsOnKarmaSkills;
        private Chummer.ColorableCheckBox chkDontDoubleQualityRefunds;
        private Chummer.ColorableCheckBox chkReverseAttributePriorityOrder;
        private System.Windows.Forms.Label label2;
        private Chummer.ColorableCheckBox chkStrictSkillGroups;
        private Chummer.NumericUpDownEx nudContactMultiplier;
        private Chummer.ColorableCheckBox chkPrioritySpellsAsAdeptPowers;
        private Chummer.ColorableCheckBox chkAllowInitiation;
        private Chummer.ColorableCheckBox chkFreeMartialArtSpecialization;
        private Chummer.ColorableCheckBox chkAllowCyberwareESSDiscounts;
        private Chummer.ColorableCheckBox chkMysAdPp;
        private Chummer.ColorableCheckBox chkESSLossReducesMaximumOnly;
        private Chummer.ColorableCheckBox chkAlternateMetatypeAttributeKarma;
        private Chummer.ColorableCheckBox chkUseCalculatedPublicAwareness;
        private Chummer.NumericUpDownEx nudDroneArmorMultiplier;
        private System.Windows.Forms.Label label4;
        private Chummer.ColorableCheckBox chkDroneArmorMultiplier;
        private Chummer.ColorableCheckBox chkContactMultiplier;
        private Chummer.ColorableCheckBox chkKnowledgeMultiplier;
        private System.Windows.Forms.Label label3;
        private Chummer.NumericUpDownEx nudKnowledgeMultiplier;
        private Chummer.ColorableCheckBox chkUseTotalValueForFreeContacts;
        private Chummer.ColorableCheckBox chkIgnoreComplexFormLimit;
        private Chummer.ColorableCheckBox chkSpecialKarmaCost;
        private Chummer.ColorableCheckBox chkMoreLethalGameplay;
        private Chummer.ColorableCheckBox chkExtendAnyDetectionSpell;
        private Chummer.ColorableCheckBox chkAllowSkillRegrouping;
        private Chummer.ColorableCheckBox chkNoArmorEncumbrance;
        private Chummer.ColorableCheckBox chkIncreasedImprovedAbilityModifier;
        private Chummer.ColorableCheckBox chkAllowFreeGrids;
        private Chummer.ColorableCheckBox chkAllowTechnomancerSchooling;
        private Chummer.ColorableCheckBox chkUsePointsOnBrokenGroups;
        private Chummer.ColorableCheckBox chkUnclampAttributeMinimum;
        private System.Windows.Forms.TabPage tabGitHubIssues;
        private System.Windows.Forms.Button cmdUploadPastebin;
        private System.Windows.Forms.TabPage tabPlugins;
        private BufferedTableLayoutPanel tlpPlugins;
        private System.Windows.Forms.GroupBox grpAvailablePlugins;
        private System.Windows.Forms.CheckedListBox clbPlugins;
        private System.Windows.Forms.Panel panelPluginOption;
        private System.Windows.Forms.FlowLayoutPanel flpOKCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private ElasticComboBox cboMugshotCompression;
        private System.Windows.Forms.FlowLayoutPanel flpMugshotCompressionQuality;
        private System.Windows.Forms.Label lblMugshotCompressionQuality;
        private Chummer.NumericUpDownEx nudMugshotCompressionQuality;
        private System.Windows.Forms.GroupBox gpbSourcebook;
        private Chummer.ColorableCheckBox chkHideMasterIndex;
        private System.Windows.Forms.TableLayoutPanel tlpKarmaCosts;
        private BufferedTableLayoutPanel tlpKarmaCostsList;
        private System.Windows.Forms.Label lblKarmaNuyenPerExtra;
        private Chummer.NumericUpDownEx nudKarmaNuyenPer;
        private System.Windows.Forms.Label lblKarmaNuyenPer;
        private System.Windows.Forms.Label lblKarmaImproveKnowledgeSkill;
        private Chummer.NumericUpDownEx nudKarmaImproveKnowledgeSkill;
        private System.Windows.Forms.Label lblKarmaImproveKnowledgeSkillExtra;
        private System.Windows.Forms.Label lblKarmaImproveActiveSkill;
        private Chummer.NumericUpDownEx nudKarmaImproveActiveSkill;
        private System.Windows.Forms.Label lblKarmaImproveActiveSkillExtra;
        private System.Windows.Forms.Label lblKarmaImproveSkillGroup;
        private Chummer.NumericUpDownEx nudKarmaImproveSkillGroup;
        private System.Windows.Forms.Label lblKarmaImproveSkillGroupExtra;
        private System.Windows.Forms.Label lblKarmaAttribute;
        private Chummer.NumericUpDownEx nudKarmaAttribute;
        private System.Windows.Forms.Label lblKarmaAttributeExtra;
        private System.Windows.Forms.Label lblKarmaQuality;
        private Chummer.NumericUpDownEx nudKarmaQuality;
        private System.Windows.Forms.Label lblKarmaQualityExtra;
        private System.Windows.Forms.Label lblKarmaAlchemicalFocusExtra;
        private Chummer.NumericUpDownEx nudKarmaAlchemicalFocus;
        private System.Windows.Forms.Label lblKarmaAlchemicalFocus;
        private System.Windows.Forms.Label lblKarmaBanishingFocus;
        private Chummer.NumericUpDownEx nudKarmaBanishingFocus;
        private System.Windows.Forms.Label lblKarmaBanishingFocusExtra;
        private System.Windows.Forms.Label lblKarmaBindingFocus;
        private Chummer.NumericUpDownEx nudKarmaBindingFocus;
        private System.Windows.Forms.Label lblKarmaBindingFocusExtra;
        private System.Windows.Forms.Label lblKarmaCenteringFocus;
        private Chummer.NumericUpDownEx nudKarmaCenteringFocus;
        private System.Windows.Forms.Label lblKarmaCenteringFocusExtra;
        private System.Windows.Forms.Label lblKarmaCounterspellingFocus;
        private Chummer.NumericUpDownEx nudKarmaCounterspellingFocus;
        private System.Windows.Forms.Label lblKarmaCounterspellingFocusExtra;
        private System.Windows.Forms.Label lblKarmaDisenchantingFocus;
        private Chummer.NumericUpDownEx nudKarmaDisenchantingFocus;
        private System.Windows.Forms.Label lblKarmaDisenchantingFocusExtra;
        private System.Windows.Forms.Label lblKarmaFlexibleSignatureFocus;
        private Chummer.NumericUpDownEx nudKarmaFlexibleSignatureFocus;
        private System.Windows.Forms.Label lblFlexibleSignatureFocusExtra;
        private System.Windows.Forms.Label lblKarmaMaskingFocus;
        private Chummer.NumericUpDownEx nudKarmaMaskingFocus;
        private System.Windows.Forms.Label lblKarmaMaskingFocusExtra;
        private System.Windows.Forms.Label lblKarmaPowerFocus;
        private Chummer.NumericUpDownEx nudKarmaPowerFocus;
        private System.Windows.Forms.Label lblKarmaPowerFocusExtra;
        private System.Windows.Forms.Label lblKarmaQiFocus;
        private Chummer.NumericUpDownEx nudKarmaQiFocus;
        private System.Windows.Forms.Label lblKarmaQiFocusExtra;
        private System.Windows.Forms.Label lblKarmaRitualSpellcastingFocus;
        private Chummer.NumericUpDownEx nudKarmaRitualSpellcastingFocus;
        private System.Windows.Forms.Label lblKarmaRitualSpellcastingFocusExtra;
        private System.Windows.Forms.Label lblKarmaSpellcastingFocus;
        private Chummer.NumericUpDownEx nudKarmaSpellcastingFocus;
        private System.Windows.Forms.Label lblKarmaSpellcastingFocusExtra;
        private System.Windows.Forms.Label lblKarmaSummoningFocus;
        private Chummer.NumericUpDownEx nudKarmaSummoningFocus;
        private System.Windows.Forms.Label lblKarmaSummoningFocusExtra;
        private System.Windows.Forms.Label lblKarmaSustainingFocus;
        private Chummer.NumericUpDownEx nudKarmaSustainingFocus;
        private System.Windows.Forms.Label lblKarmaSustainingFocusExtra;
        private System.Windows.Forms.Label lblKarmaSpellShapingFocus;
        private System.Windows.Forms.Label lblKarmaSpellShapingFocusExtra;
        private Chummer.NumericUpDownEx nudKarmaSpellShapingFocus;
        private System.Windows.Forms.Label lblKarmaWeaponFocus;
        private System.Windows.Forms.Label lblKarmaWeaponFocusExtra;
        private Chummer.NumericUpDownEx nudKarmaWeaponFocus;
        private System.Windows.Forms.Label lblMetatypeCostsKarmaMultiplierLabel;
        private System.Windows.Forms.Label lblKarmaNewAIAdvancedProgram;
        private System.Windows.Forms.Label lblKarmaNewAIProgram;
        private System.Windows.Forms.Label lblKarmaTechnique;
        private System.Windows.Forms.Label lblKarmaNewComplexForm;
        private System.Windows.Forms.Label lblKarmaSpell;
        private System.Windows.Forms.Label lblKarmaLeaveGroup;
        private System.Windows.Forms.Label lblKarmaJoinGroup;
        private System.Windows.Forms.Label lblKarmaMetamagic;
        private Chummer.NumericUpDownEx nudMetatypeCostsKarmaMultiplier;
        private Chummer.NumericUpDownEx nudKarmaNewAIAdvancedProgram;
        private Chummer.NumericUpDownEx nudKarmaNewAIProgram;
        private Chummer.NumericUpDownEx nudKarmaTechnique;
        private Chummer.NumericUpDownEx nudKarmaNewComplexForm;
        private Chummer.NumericUpDownEx nudKarmaSpell;
        private Chummer.NumericUpDownEx nudKarmaLeaveGroup;
        private Chummer.NumericUpDownEx nudKarmaJoinGroup;
        private Chummer.NumericUpDownEx nudKarmaMetamagic;
        private Chummer.NumericUpDownEx nudKarmaSpecialization;
        private Chummer.NumericUpDownEx nudKarmaKnowledgeSpecialization;
        private Chummer.NumericUpDownEx nudKarmaNewKnowledgeSkill;
        private Chummer.NumericUpDownEx nudKarmaNewActiveSkill;
        private Chummer.NumericUpDownEx nudKarmaNewSkillGroup;
        private System.Windows.Forms.Label lblKarmaSpecialization;
        private System.Windows.Forms.Label lblKarmaKnowledgeSpecialization;
        private System.Windows.Forms.Label lblKarmaNewKnowledgeSkill;
        private System.Windows.Forms.Label lblKarmaNewActiveSkill;
        private System.Windows.Forms.Label lblKarmaNewSkillGroup;
        private System.Windows.Forms.Label lblKarmaContact;
        private Chummer.NumericUpDownEx nudKarmaContact;
        private System.Windows.Forms.Label lblKarmaContactExtra;
        private System.Windows.Forms.Label lblKarmaEnemy;
        private Chummer.NumericUpDownEx nudKarmaEnemy;
        private System.Windows.Forms.Label lblKarmaEnemyExtra;
        private System.Windows.Forms.Label lblNuyenPerBP;
        private Chummer.NumericUpDownEx nudNuyenPerBP;
        private System.Windows.Forms.Label lblKarmaCarryover;
        private Chummer.NumericUpDownEx nudKarmaCarryover;
        private System.Windows.Forms.Label lblKarmaCarryoverExtra;
        private System.Windows.Forms.FlowLayoutPanel flpKarmaInitiation;
        private System.Windows.Forms.Label lblKarmaInitiation;
        private System.Windows.Forms.Label lblKarmaInitiationBracket;
        private Chummer.NumericUpDownEx nudKarmaInitiation;
        private System.Windows.Forms.FlowLayoutPanel flpKarmaInitiationExtra;
        private System.Windows.Forms.Label lblKarmaInitiationExtra;
        private Chummer.NumericUpDownEx nudKarmaInitiationFlat;
        private System.Windows.Forms.Label lblKarmaSpirit;
        private Chummer.NumericUpDownEx nudKarmaSpirit;
        private System.Windows.Forms.Label lblKarmaSpiritExtra;
        private System.Windows.Forms.Label lblKarmaMysticAdeptPowerPoint;
        private Chummer.NumericUpDownEx nudKarmaMysticAdeptPowerPoint;
        private System.Windows.Forms.FlowLayoutPanel flpDroneArmorMultiplier;
        private System.Windows.Forms.FlowLayoutPanel flpContactMultiplier;
        private System.Windows.Forms.FlowLayoutPanel flpKnowledgeMultiplier;
        private System.Windows.Forms.FlowLayoutPanel flpCyberlimbAttributeBonusCap;
        private System.Windows.Forms.Label lblColorMode;
        private System.Windows.Forms.ComboBox cboColorMode;
        private System.Windows.Forms.TableLayoutPanel tlpColorMode;
    }
}
