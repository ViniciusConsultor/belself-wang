using System;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraBars.Localization;
using DevExpress.XtraNavBar;
using DevExpress.XtraPrinting.Localization;
//using DevExpress.XtraReports.Localization;
using DevExpress.XtraTreeList.Localization;
using DevExpress.XtraVerticalGrid.Localization;
using DevExpress.XtraLayout.Localization;

namespace BWSERP
{
    /// <summary>
    /// DEV �ؼ�������Դ
    /// ֱ�ӽ�������빤�̼��ɣ�����Program��ʵ����
    /// </summary>
    public class Chinese
    {
        public Chinese()
        {
            Localizer.Active = new XtraEditors_CN();
            GridLocalizer.Active = new XtraGrid_CN();
            BarLocalizer.Active = new XtraBar_CN();
            BarLocalizer.Active.Customization = new XtraBarsCustomizationLocalization_CN();
            NavBarLocalizer.Active = new XtraNavBar_CN();
            PreviewLocalizer.Active = new XtraPrinting_CN();
            //ReportLocalizer.Active = new XtraReports_CN();
            TreeListLocalizer.Active = new XtraTreeList_CN();
            VGridLocalizer.Active = new XtraVerticalGrid_CN();
            LayoutLocalizer.Active = new XtraLayout_CN();
        }
    }

    public class XtraEditors_CN : Localizer
    {
        public XtraEditors_CN()
        {
            //
            // TODO: �ڴ˴����ӹ��캯���߼�
            //
        }
        public override string Language
        {
            get
            {
                return "��������";
            }
        }
        public override string GetLocalizedString(StringId id)
        {
            switch (id)
            {
                case StringId.TextEditMenuCopy: return "����(&C)";
                case StringId.TextEditMenuCut: return "����(&T)";
                case StringId.TextEditMenuDelete: return "ɾ��(&D)";
                case StringId.TextEditMenuPaste: return "ճ��(&P)";
                case StringId.TextEditMenuSelectAll: return "ȫѡ(&A)";
                case StringId.TextEditMenuUndo: return "����(&U)";
                case StringId.UnknownPictureFormat: return "δ֪ͼƬ��ʽ";
                case StringId.DateEditToday: return "����";
                case StringId.DateEditClear: return "���";
                case StringId.DataEmpty: return "��ͼ��";
                case StringId.ColorTabWeb: return "��ҳ";
                case StringId.ColorTabSystem: return "ϵͳ";
                case StringId.ColorTabCustom: return "�Զ���";
                case StringId.CheckUnchecked: return "δѡ��";
                case StringId.CheckIndeterminate: return "��ȷ��";
                case StringId.CheckChecked: return "��ѡ��";
                case StringId.CaptionError: return "�������";
                case StringId.Cancel: return "ȡ��";
                case StringId.CalcError: return "�������";
                case StringId.CalcButtonBack: return base.GetLocalizedString(id);
                case StringId.CalcButtonC: return base.GetLocalizedString(id);
                case StringId.CalcButtonCE: return base.GetLocalizedString(id); ;
                case StringId.CalcButtonMC: return base.GetLocalizedString(id);
                case StringId.CalcButtonMR: return base.GetLocalizedString(id);
                case StringId.CalcButtonMS: return base.GetLocalizedString(id);
                case StringId.CalcButtonMx: return base.GetLocalizedString(id);
                case StringId.CalcButtonSqrt: return base.GetLocalizedString(id);
                case StringId.OK: return "ȷ��";
                case StringId.PictureEditMenuCopy: return "����(&C)";
                case StringId.PictureEditMenuCut: return "����(&T)";
                case StringId.PictureEditMenuDelete: return "ɾ��(&D)";
                case StringId.PictureEditMenuLoad: return "����(&L)";
                case StringId.PictureEditMenuPaste: return "ճ��(&P)";
                case StringId.PictureEditMenuSave: return "����(&S)";
                case StringId.PictureEditOpenFileError: return "����ͼƬ��ʽ";
                case StringId.PictureEditOpenFileErrorCaption: return "�򿪴���";
                case StringId.PictureEditOpenFileFilter: return "λͼ�ļ�(*.bmp)|*.bmp|GIF���� (*.gif)|*.gif|JPEG(*.jpg;*.jpeg)|*.jpg;*.jpeg|ICO(*.ico)|*.ico|����ͼƬ�ļ�|*.bmp;*.gif;*.jpeg;*.jpg;*.ico|�����ļ�(*.*)|*.*";
                case StringId.PictureEditOpenFileTitle: return "��";
                case StringId.PictureEditSaveFileFilter: return "λͼ�ļ�(*.bmp)|*.bmp|GIF����(*.gif)|*.gif|JPEG(*.jpg)|*.jpg";
                case StringId.PictureEditSaveFileTitle: return "����Ϊ";
                case StringId.TabHeaderButtonClose: return "�ر�";
                case StringId.TabHeaderButtonNext: return "��һҳ";
                case StringId.TabHeaderButtonPrev: return "��һҳ";
                case StringId.XtraMessageBoxAbortButtonText: return "�ж�(&A)";
                case StringId.XtraMessageBoxCancelButtonText: return "ȡ��(&C)";
                case StringId.XtraMessageBoxIgnoreButtonText: return "����(&I)";
                case StringId.XtraMessageBoxNoButtonText: return "��(&N)";
                case StringId.XtraMessageBoxOkButtonText: return "ȷ��(&O)";
                case StringId.XtraMessageBoxRetryButtonText: return "����(&R)";
                case StringId.XtraMessageBoxYesButtonText: return "��(&Y)";
                case StringId.ImagePopupEmpty: return "(��)";
                case StringId.ImagePopupPicture: return "(ͼƬ)";
                case StringId.InvalidValueText: return "��Ч��ֵ";
                case StringId.LookUpEditValueIsNull: return "[������]";
                case StringId.LookUpInvalidEditValueType: return "��Ч����������";
                case StringId.MaskBoxValidateError: return "������ֵ������. �Ƿ���Ҫ�޸�? �� - �ص��༭ģʽ���޸���ֵ. �� - ����ԭ����ֵ. ȡ�� - �ظ�ԭ����ֵ. ";
                case StringId.NavigatorAppendButtonHint: return "����";
                case StringId.NavigatorCancelEditButtonHint: return "ȡ���༭";
                case StringId.NavigatorEditButtonHint: return "�༭";
                case StringId.NavigatorEndEditButtonHint: return "�����༭";
                case StringId.NavigatorFirstButtonHint: return "��һ��";
                case StringId.NavigatorLastButtonHint: return "���һ��";
                case StringId.NavigatorNextButtonHint: return "��һ��";
                case StringId.NavigatorNextPageButtonHint: return "��һҳ";
                case StringId.NavigatorPreviousButtonHint: return "��һ��";
                case StringId.NavigatorPreviousPageButtonHint: return "��һҳ";
                case StringId.NavigatorRemoveButtonHint: return "ɾ��";
                case StringId.NavigatorTextStringFormat: return "��¼{0}/{1}";
                case StringId.None: return "";
                case StringId.NotValidArrayLength: return "��Ч�����鳤��.";
            }
            return base.GetLocalizedString(id);
        }
    }

    public class XtraGrid_CN : GridLocalizer
    {
        public override string Language
        {
            get
            {
                return "��������";
            }
        }
        public override string GetLocalizedString(GridStringId id)
        {
            switch (id)
            {
                //case GridStringId.CardViewCaptionFormat: return "��¼ N {0}";
                //case GridStringId.CardViewNewCard: return "�¿�Ƭ";
                //case GridStringId.CardViewQuickCustomizationButton: return "�Զ����ʽ";
                //case GridStringId.CardViewQuickCustomizationButtonFilter: return "������";
                //case GridStringId.CardViewQuickCustomizationButtonSort: return "����";
                //case GridStringId.ColumnViewExceptionMessage: return " Ҫ������ǰֵ��?";
                //case GridStringId.CustomFilterDialog2FieldCheck: return "�ֶ�";
                //case GridStringId.CustomFilterDialogCancelButton: return "ȡ��";
                //case GridStringId.CustomFilterDialogCaption: return "��ʾ����������������:";
                //case GridStringId.CustomFilterDialogConditionBlanks: return "��ֵ";
                //case GridStringId.CustomFilterDialogConditionEQU: return "����=";
                //case GridStringId.CustomFilterDialogConditionGT: return "����>";
                //case GridStringId.CustomFilterDialogConditionGTE: return "���ڻ����>=";
                //case GridStringId.CustomFilterDialogConditionLike: return "����";
                //case GridStringId.CustomFilterDialogConditionLT: return "С��<";
                //case GridStringId.CustomFilterDialogConditionLTE: return "С�ڻ����>=";
                //case GridStringId.CustomFilterDialogConditionNEQ: return "������<>";
                //case GridStringId.CustomFilterDialogConditionNonBlanks: return "�ǿ�ֵ";
                //case GridStringId.CustomFilterDialogConditionNotLike: return "������";
                //case GridStringId.CustomFilterDialogFormCaption: return "�û��Զ����Զ�������";
                //case GridStringId.CustomFilterDialogHint: return "�� _ ���һ�����ַ�#�� % ��������κ����͵��ַ�";
                //case GridStringId.CustomFilterDialogOkButton: return "ȷ��(&O)";
                //case GridStringId.CustomFilterDialogRadioAnd: return "��(&A)";
                //case GridStringId.CustomFilterDialogRadioOr: return "����(&O)";
                //case GridStringId.CustomizationBands: return "����";
                //case GridStringId.CustomizationCaption: return "�Զ�����ʾ�ֶ�";
                //case GridStringId.CustomizationColumns: return "��";
                //case GridStringId.FileIsNotFoundError: return "�ļ�{0}û�ҵ�!";
                //case GridStringId.GridGroupPanelText: return "�϶��б�������,���ݸ��з���";
                //case GridStringId.GridNewRowText: return "������������һ��";
                //case GridStringId.GridOutlookIntervals: return "����;�ϸ���;���³�;����֮ǰ;����֮ǰ;����;;;;;;;;����;����;����;;;;;;;;����;���ܺ�;���ܺ�;���µ�;�¸���;һ����֮��;";
                //case GridStringId.MenuColumnBestFit: return "����Ӧ�п�";
                //case GridStringId.MenuColumnBestFitAllColumns: return "����Ӧ�п�(������)";
                //case GridStringId.MenuColumnClearFilter: return "���ɸѡ����";
                //case GridStringId.MenuColumnColumnCustomization: return "��ʾ/�����ֶ�";
                //case GridStringId.MenuColumnFilter: return "ɸѡ";
                //case GridStringId.MenuColumnGroup: return "�����з���";
                //case GridStringId.MenuColumnGroupBox: return "������";
                //case GridStringId.MenuColumnSortAscending: return "��������";
                //case GridStringId.MenuColumnSortDescending: return "��������";
                //case GridStringId.MenuColumnUnGroup: return "ȡ������";
                //case GridStringId.MenuGroupPanelHide: return "���ط�����";
                //case GridStringId.MenuGroupPanelShow: return "��ʾ������";
                //case GridStringId.MenuFooterAverage: return "ƽ��";
                //case GridStringId.MenuFooterAverageFormat: return "ƽ��={0:#.##}";
                //case GridStringId.MenuFooterCount: return "����";
                //case GridStringId.MenuFooterCountFormat: return "{0}";
                //case GridStringId.MenuFooterMax: return "���ֵ";
                //case GridStringId.MenuFooterMaxFormat: return "���ֵ={0}";
                //case GridStringId.MenuFooterMin: return "��С";
                //case GridStringId.MenuFooterMinFormat: return "��Сֵ={0}";
                //case GridStringId.MenuFooterNone: return "û��";
                //case GridStringId.MenuFooterSum: return "�ϼ�";
                //case GridStringId.MenuFooterSumFormat: return "���={0:#.##}";
                //case GridStringId.MenuGroupPanelClearGrouping: return "ȡ�����з���";
                //case GridStringId.MenuGroupPanelFullCollapse: return "����ȫ������";
                //case GridStringId.MenuGroupPanelFullExpand: return "չ��ȫ������";
                //case GridStringId.PopupFilterAll: return "(����)";
                //case GridStringId.PopupFilterBlanks: return "(��ֵ)";
                //case GridStringId.PopupFilterCustom: return "(�Զ���)";
                //case GridStringId.PopupFilterNonBlanks: return "(�ǿ�ֵ)";
                //case GridStringId.PrintDesignerBandedView: return "��ӡ����(����ģʽ)";
                //case GridStringId.PrintDesignerBandHeader: return "������";
                //case GridStringId.PrintDesignerCardView: return "��ӡ����(��Ƭģʽ)";
                //case GridStringId.PrintDesignerDescription: return "Ϊ��ǰ��ͼ���ò�ͬ�Ĵ�ӡѡ��.";
                //case GridStringId.PrintDesignerGridView: return "��ӡ����(����ģʽ)";
                //case GridStringId.WindowErrorCaption: return "����";
                //case GridStringId.FilterBuilderApplyButton: return "Ӧ��";
                //case GridStringId.FilterBuilderCancelButton: return "ȡ��";
                //case GridStringId.FilterBuilderOkButton: return "ȷ��";
                //case GridStringId.FilterBuilderCaption: return "�Զ�����ϲ�ѯ";
                //case GridStringId.MenuColumnRemoveColumn: return "ɾ������";
                //case GridStringId.MenuColumnFilterEditor: return "�Զ����ѯ";
                //case GridStringId.MenuColumnClearSorting: return "�������";
                case GridStringId.CardViewCaptionFormat: return "��¼N{0}";
                case GridStringId.CardViewNewCard: return "�½���";
                case GridStringId.CardViewQuickCustomizationButton: return "�Զ���";
                case GridStringId.CardViewQuickCustomizationButtonFilter: return "������";
                case GridStringId.CardViewQuickCustomizationButtonSort: return "����ʽ:";
                case GridStringId.ColumnViewExceptionMessage: return "Ҫ������ǰֵ��?";
                case GridStringId.CustomFilterDialog2FieldCheck: return "�ֶ�";
                case GridStringId.CustomFilterDialogCancelButton: return "ȡ��(&C)";
                case GridStringId.CustomFilterDialogCaption: return "��ʾ����������������:";
                case GridStringId.CustomFilterDialogClearFilter: return "���������(&L)";
                case GridStringId.CustomFilterDialogConditionBlanks: return "�հ�";
                case GridStringId.CustomFilterDialogConditionEQU: return "����";
                case GridStringId.CustomFilterDialogConditionGT: return "����";
                case GridStringId.CustomFilterDialogConditionGTE: return "���ڻ����";
                case GridStringId.CustomFilterDialogConditionLike: return "������";
                case GridStringId.CustomFilterDialogConditionLT: return "С��";
                case GridStringId.CustomFilterDialogConditionLTE: return "С�ڻ����";
                case GridStringId.CustomFilterDialogConditionNEQ: return "������";
                case GridStringId.CustomFilterDialogConditionNonBlanks: return "�ǿհ�";
                case GridStringId.CustomFilterDialogConditionNotLike: return "������";
                case GridStringId.CustomFilterDialogEmptyOperator: return "(ѡ��һ������)";
                case GridStringId.CustomFilterDialogEmptyValue: return "(����һ��ֵ)";
                case GridStringId.CustomFilterDialogFormCaption: return "�û��Զ����Զ�������";
                case GridStringId.CustomFilterDialogHint: return "�� _ ���һ�����ַ�#�� % ��������κ����͵��ַ�";
                case GridStringId.CustomFilterDialogOkButton: return "ȷ��(&O)";
                case GridStringId.CustomFilterDialogRadioAnd: return "��(&A)";
                case GridStringId.CustomFilterDialogRadioOr: return "��(&O)";
                case GridStringId.CustomizationBands: return "����";
                case GridStringId.CustomizationCaption: return "�Զ���";
                case GridStringId.CustomizationColumns: return "��";
                case GridStringId.CustomizationFormBandHint: return "�ڴ������������Ʋ���";
                case GridStringId.CustomizationFormColumnHint: return "�ڴ������������Ʋ���";
                case GridStringId.FileIsNotFoundError: return "�ļ�{0}�Ҳ���";
                case GridStringId.FilterBuilderApplyButton: return "Ӧ��(&A)";
                case GridStringId.FilterBuilderCancelButton: return "ȡ��(&C)";
                case GridStringId.FilterBuilderCaption: return "����ɸѡ�����趨��";
                case GridStringId.FilterBuilderOkButton: return "ȷ��(&O)";
                case GridStringId.FilterPanelCustomizeButton: return "�Զ���";
                case GridStringId.GridGroupPanelText: return "�϶��б�������,���ݸ��з���";
                case GridStringId.GridNewRowText: return "�ڴ˴�����һ��";
                case GridStringId.GridOutlookIntervals: return "����;�ϸ���;���³�;����֮ǰ;����֮ǰ;����;;;;;;;;����;����;����;;;;;;;;����;���ܺ�;���ܺ�;���µ�;�¸���;һ����֮��;";
                case GridStringId.LayoutModifiedWarning: return "�����ѱ����ģ�ȷ��Ҫ���������";
                case GridStringId.LayoutViewButtonApply: return "Ӧ��(&A)";
                case GridStringId.LayoutViewButtonCancel: return "ȡ��(&C)";
                case GridStringId.LayoutViewButtonCustomizeHide: return "�����Զ���(&z)";
                case GridStringId.LayoutViewButtonCustomizeShow: return "��ʾ�Զ���(&S)";
                case GridStringId.LayoutViewButtonLoadLayout: return "�������(&L)...";
                case GridStringId.LayoutViewButtonOk: return "ȷ��(&O)";
                case GridStringId.LayoutViewButtonPreview: return "��ʾ���࿨(&M)";
                case GridStringId.LayoutViewButtonReset: return "���ÿ�ģ��(&R)";
                case GridStringId.LayoutViewButtonSaveLayout: return "�������...(&v)";
                case GridStringId.LayoutViewButtonShrinkToMinimum: return "������ģ��(&S)";
                case GridStringId.LayoutViewCardCaptionFormat: return "��¼[{0}/{1}]";
                case GridStringId.LayoutViewCarouselModeBtnHint: return "��תģʽ";
                case GridStringId.LayoutViewCloseZoomBtnHintClose: return "��ԭ��ͼ";
                case GridStringId.LayoutViewCloseZoomBtnHintZoom: return "�����ϸ��Ϣ";
                case GridStringId.LayoutViewColumnModeBtnHint: return "һ����λ";
                case GridStringId.LayoutViewCustomizationFormCaption: return "�Զ���鿴���";
                case GridStringId.LayoutViewCustomizationFormDescription: return "ͨ���Ϸ��Զ��忨���Ͳ˵������ҿ��ڲ鿴�����Ԥ������.";
                case GridStringId.LayoutViewCustomizeBtnHint: return "�Զ���";
                case GridStringId.LayoutViewFieldCaptionFormat: return "{0}:";
                case GridStringId.LayoutViewGroupCaptions: return "����";
                case GridStringId.LayoutViewGroupCards: return "��";
                case GridStringId.LayoutViewGroupCustomization: return "�Զ���";
                case GridStringId.LayoutViewGroupFields: return "����";
                case GridStringId.LayoutViewGroupHiddenItems: return "������";
                case GridStringId.LayoutViewGroupIndents: return "����";
                case GridStringId.LayoutViewGroupIntervals: return "���";
                case GridStringId.LayoutViewGroupLayout: return "����";
                case GridStringId.LayoutViewGroupPropertyGrid: return "����դ��";
                case GridStringId.LayoutViewGroupTreeStructure: return "���β��ֲ鿴";
                case GridStringId.LayoutViewGroupView: return "�鿴";
                case GridStringId.LayoutViewLabelAllowFieldHotTracking: return "�����ȸ���";
                case GridStringId.LayoutViewLabelCaptionLocation: return "��������λ��";
                case GridStringId.LayoutViewLabelCardArrangeRule: return "���й���:";
                case GridStringId.LayoutViewLabelCardEdgeAlignment: return "����Ե���뷽ʽ:";
                case GridStringId.LayoutViewLabelGroupCaptionLocation: return "�����λ��:";
                case GridStringId.LayoutViewLabelHorizontal: return "ˮƽ���";
                case GridStringId.LayoutViewLabelPadding: return "���";
                case GridStringId.LayoutViewLabelScrollVisibility: return "�������ɼ�:";
                case GridStringId.LayoutViewLabelShowCardBorder: return "��ʾ�߽�";
                case GridStringId.LayoutViewLabelShowCardCaption: return "��ʾ����";
                case GridStringId.LayoutViewLabelShowCardExpandButton: return "��ʾչ����ť";
                case GridStringId.LayoutViewLabelShowFieldBorder: return "��ʾ�߽�";
                case GridStringId.LayoutViewLabelShowFieldHint: return "��ʾ��ʾ";
                case GridStringId.LayoutViewLabelShowFilterPanel: return "��ʾ�������";
                case GridStringId.LayoutViewLabelShowHeaderPanel: return "��ʾ��ͷ���";
                case GridStringId.LayoutViewLabelShowLines: return "��ʾ����";
                case GridStringId.LayoutViewLabelSpacing: return "���";
                case GridStringId.LayoutViewLabelTextAlignment: return "�ı����䷽ʽ:";
                case GridStringId.LayoutViewLabelTextIndent: return "�ı�����";
                case GridStringId.LayoutViewLabelVertical: return "��ֱ���";
                case GridStringId.LayoutViewLabelViewMode: return "�鿴ģʽ";
                case GridStringId.LayoutViewMultiColumnModeBtnHint: return "����";
                case GridStringId.LayoutViewMultiRowModeBtnHint: return "����";
                case GridStringId.LayoutViewPageTemplateCard: return "ģ�忨";
                case GridStringId.LayoutViewPageViewLayout: return "�鿴����";
                case GridStringId.LayoutViewPanBtnHint: return "���";
                case GridStringId.LayoutViewRowModeBtnHint: return "����";
                case GridStringId.LayoutViewSingleModeBtnHint: return "����";
                case GridStringId.MenuColumnBestFit: return "���ƥ��";
                case GridStringId.MenuColumnBestFitAllColumns: return "���ƥ��(������)";
                case GridStringId.MenuColumnClearFilter: return "���������";
                case GridStringId.MenuColumnClearSorting: return "�����������";
                case GridStringId.MenuColumnColumnCustomization: return "��ѡ��";
                case GridStringId.MenuColumnFilter: return "����ɸѡ����";
                case GridStringId.MenuColumnFilterEditor: return "�趨����ɸѡ����";
                case GridStringId.MenuColumnGroup: return "���ݴ��з���";
                case GridStringId.MenuColumnGroupBox: return "�������ݿ�";
                case GridStringId.MenuColumnGroupSummarySortFormat: return "{1}����-'{0}'-{2}";
                case GridStringId.MenuColumnRemoveColumn: return "�Ƴ���";
                case GridStringId.MenuColumnResetGroupSummarySort: return "���ժҪ����";
                case GridStringId.MenuColumnShowColumn: return "��ʾ��";
                case GridStringId.MenuColumnSortAscending: return "��������";
                case GridStringId.MenuColumnSortDescending: return "��������";
                case GridStringId.MenuColumnSortGroupBySummaryMenu: return "��ժҪ����";
                case GridStringId.MenuColumnUnGroup: return "������";
                case GridStringId.MenuFooterAverage: return "ƽ��ֵ";
                case GridStringId.MenuFooterAverageFormat: return "ƽ��={0:#.##}";
                case GridStringId.MenuFooterCount: return "����";
                case GridStringId.MenuFooterCountFormat: return "{0}";
                case GridStringId.MenuFooterCountGroupFormat: return "����={0}";
                case GridStringId.MenuFooterCustomFormat: return "ͳ��ֵ={0}";
                case GridStringId.MenuFooterMax: return "���ֵ";
                case GridStringId.MenuFooterMaxFormat: return "���ֵ={0}";
                case GridStringId.MenuFooterMin: return "��Сֵ";
                case GridStringId.MenuFooterMinFormat: return "��Сֵ={0}";
                case GridStringId.MenuFooterNone: return "��";
                case GridStringId.MenuFooterSum: return "��";
                case GridStringId.MenuFooterSumFormat: return "��={0:#.##}";
                case GridStringId.MenuGroupPanelClearGrouping: return "�������";
                case GridStringId.MenuGroupPanelFullCollapse: return "ȫ���պ�";
                case GridStringId.MenuGroupPanelFullExpand: return "ȫ��չ��";
                case GridStringId.PopupFilterAll: return "(ȫ��)";
                case GridStringId.PopupFilterBlanks: return "(�հ�)";
                case GridStringId.PopupFilterCustom: return "(�Զ���)";
                case GridStringId.PopupFilterNonBlanks: return "(�޿հ�)";
                case GridStringId.PrintDesignerBandedView: return "��ӡ����(Banded View)";
                case GridStringId.PrintDesignerBandHeader: return "��ʼ����";
                case GridStringId.PrintDesignerCardView: return "��ӡ����(����ͼ)";
                case GridStringId.PrintDesignerDescription: return "Ϊ��ǰ��ͼ���ò�ͬ�Ĵ�ӡѡ��";
                case GridStringId.PrintDesignerGridView: return "��ӡ����(������ͼ)";
                case GridStringId.PrintDesignerLayoutView: return "��ӡ����(������ͼ)";
                case GridStringId.MenuGroupPanelHide: return "���ط�����";
                case GridStringId.MenuGroupPanelShow: return "��ʾ������";

            }
            return base.GetLocalizedString(id);
        }
    }

    public class XtraBar_CN : BarLocalizer
    {
        public override string Language
        {
            get
            {
                return "��������";
            }
        }
        public override string GetLocalizedString(BarString id)
        {
            switch (id)
            {
                case BarString.AddOrRemove: return "������ɾ����ť(&A)";
                case BarString.CustomizeButton: return "�Զ���(&C)";
                case BarString.CustomizeWindowCaption: return "�Զ���";
                case BarString.MenuAnimationFade: return "����";
                case BarString.MenuAnimationNone: return "��";
                case BarString.MenuAnimationRandom: return "����";
                case BarString.MenuAnimationSlide: return "����";
                case BarString.MenuAnimationSystem: return "(ϵͳĬ��ֵ)";
                case BarString.MenuAnimationUnfold: return "չ��";
                case BarString.NewToolbarCaption: return "�½�������";
                case BarString.None: return "";
                case BarString.RenameToolbarCaption: return "��������";
                case BarString.ResetBar: return "�Ƿ�ȷʵҪ���ö� '{0}' �������������޸ģ�";
                case BarString.ResetBarCaption: return "�Զ���";
                case BarString.ResetButton: return "���蹤����(&R)";
                case BarString.ToolBarMenu: return "����(&R)$ɾ��(&D)$!����(&N)$!��׼(&L)$��ʹ������(&T)$�ڲ˵���ֻ������(&O)$ͼ�����ı�(&A)$!��ʼһ��(&G)$���õ�(&M)";
                case BarString.ToolbarNameCaption: return "����������(&T):";
            }
            return base.GetLocalizedString(id);
        }
    }

    public class XtraBarsCustomizationLocalization_CN : CustomizationControl
    {
        private System.ComponentModel.Container components = null;
        public XtraBarsCustomizationLocalization_CN()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
            // TODO: Add any initialization after the InitForm call
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tpOptions.SuspendLayout();
            this.tpCommands.SuspendLayout();
            this.tpToolbars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptionsShowFullMenus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_showFullMenusAfterDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_showTips.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_ShowShortcutInTips.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNBDlgName.Properties)).BeginInit();
            this.pnlNBDlg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_largeIcons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_MenuAnimation.Properties)).BeginInit();
            this.SuspendLayout();

            this.btClose.Text = "�ر�";
            this.btResetBar.Text = "��������(&R)";
            this.btRenameBar.Text = "������(&E)";
            this.btNewBar.Text = "�½�(&N)";
            this.btDeleteBar.Text = "ɾ��(&D)";
            this.btOptions_Reset.Text = "���ù�������(&R)";
            this.btNBDlgCancel.Text = "ȡ��";
            this.btNBDlgOk.Text = "ȷ��";
            this.tpOptions.Size = new System.Drawing.Size(354, 246);
            this.tpOptions.Text = "ѡ��(&O)";
            this.tpCommands.Text = "����(&C)";
            this.tpToolbars.Text = "������(&B)";
            this.cbOptionsShowFullMenus.Properties.Caption = "ʼ����ʾ�����˵�(&N)";
            this.cbOptions_showFullMenusAfterDelay.Properties.Caption = "���ָ�����ͣ������ʾ�����˵�(&U)";
            this.cbOptions_largeIcons.Properties.Caption = "��ͼ��(&L)";
            this.cbOptions_showTips.Properties.Caption = "��ʾ���ڹ�������Ļ��ʾ(&T)";
            this.cbOptions_ShowShortcutInTips.Properties.Caption = "����Ļ��ʾ����ʾ��ݼ�(&H)";
            this.lbDescCaption.Text = "��ϸ˵��";
            this.lbOptions_Other.Text = "����";
            this.lbOptions_PCaption.Text = "���Ի��˵��͹�����";
            this.lbCategoriesCaption.Text = "���:";
            this.lbCommandsCaption.Text = "����:";
            this.lbToolbarCaption.Text = "������:";
            this.lbOptions_MenuAnimation.Text = "�˵���������(&M):";
            this.lbNBDlgCaption.Text = "����������(&T)";
            this.lbCommands.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbCommands.Appearance.Options.UseBackColor = true;
            this.Name = "XtraBarsCustomizationLocalization_CN";
            this.tpOptions.ResumeLayout(false);
            this.tpCommands.ResumeLayout(false);
            this.tpToolbars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolBarsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptionsShowFullMenus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_showFullMenusAfterDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_showTips.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_ShowShortcutInTips.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbNBDlgName.Properties)).EndInit();
            this.pnlNBDlg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_largeIcons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_MenuAnimation.Properties)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
    }

    public class XtraNavBar_CN : NavBarLocalizer
    {
        public override string Language
        {
            get
            {
                return "��������";
            }
        }
        public override string GetLocalizedString(NavBarStringId id)
        {
            switch (id)
            {
                case NavBarStringId.NavPaneChevronHint: return "���ð�ť";
                case NavBarStringId.NavPaneMenuAddRemoveButtons: return "���ӻ�ɾ����ť(&A)";
                case NavBarStringId.NavPaneMenuShowFewerButtons: return "��ʾ���ٵİ�ť(&F)";
                case NavBarStringId.NavPaneMenuShowMoreButtons: return "��ʾ����İ�ť(&M)";
            }
            return base.GetLocalizedString(id);
        }
    }

    public class XtraPrinting_CN : PreviewLocalizer
    {
        public override string Language
        {
            get
            {
                return "��������";
            }
        }
        public override string GetLocalizedString(PreviewStringId id)
        {
            switch (id)
            {
                case PreviewStringId.Button_Apply: return "Ӧ��";
                case PreviewStringId.Button_Cancel: return "ȡ��";
                case PreviewStringId.Button_Help: return "����";
                case PreviewStringId.Button_Ok: return "ȷ��";
                case PreviewStringId.EMail_From: return "From";
                case PreviewStringId.Margin_BottomMargin: return "�±߽�";
                case PreviewStringId.Margin_Inch: return "Ӣ��";
                case PreviewStringId.Margin_LeftMargin: return "��߽�";
                case PreviewStringId.Margin_Millimeter: return "����";
                case PreviewStringId.Margin_RightMargin: return "�ұ߽�";
                case PreviewStringId.Margin_TopMargin: return "�ϱ߽�";
                case PreviewStringId.MenuItem_BackgrColor: return "��ɫ(&C)";
                case PreviewStringId.MenuItem_Background: return "����(&B)";
                case PreviewStringId.MenuItem_CsvDocument: return "CSV�ļ�";
                case PreviewStringId.MenuItem_Exit: return "�˳�(&X)";
                case PreviewStringId.MenuItem_Export: return "����(&E)";
                case PreviewStringId.MenuItem_File: return "�ļ�(&F)";
                case PreviewStringId.MenuItem_GraphicDocument: return "ͼƬ�ļ�";
                case PreviewStringId.MenuItem_HtmDocument: return "HTML�ļ�";
                case PreviewStringId.MenuItem_MhtDocument: return "MHT�ļ�";
                case PreviewStringId.MenuItem_PageSetup: return "ҳ������(&U)";
                case PreviewStringId.MenuItem_PdfDocument: return "PDF�ļ�";
                case PreviewStringId.MenuItem_Print: return "��ӡ(&P)";
                case PreviewStringId.MenuItem_PrintDirect: return "ֱ�Ӵ�ӡ(&R)";
                case PreviewStringId.MenuItem_RtfDocument: return "RTF�ļ�";
                case PreviewStringId.MenuItem_Send: return "����(&D)";
                case PreviewStringId.MenuItem_TxtDocument: return "TXT�ļ�";
                case PreviewStringId.MenuItem_View: return "��ͼ(&V)";
                case PreviewStringId.MenuItem_ViewStatusbar: return "״̬��(&S)";
                case PreviewStringId.MenuItem_ViewToolbar: return "������(&T)";
                case PreviewStringId.MenuItem_Watermark: return "ˮӡ(&W)";
                case PreviewStringId.MenuItem_XlsDocument: return "XLS�ļ�";
                case PreviewStringId.MPForm_Lbl_Pages: return "ҳ";
                case PreviewStringId.Msg_CreatingDocument: return "���������ļ�";
                case PreviewStringId.Msg_CustomDrawWarning: return "����!";
                case PreviewStringId.Msg_EmptyDocument: return "���ļ�û��ҳ��.";
                case PreviewStringId.Msg_FontInvalidNumber: return "�����С����Ϊ0����";
                case PreviewStringId.Msg_IncorrectPageRange: return "���õ�ҳ�߽粻��ȷ";
                case PreviewStringId.Msg_NeedPrinter: return "û�а�װ��ӡ��.";
                case PreviewStringId.Msg_NotSupportedFont: return "�������岻��֧��";
                case PreviewStringId.Msg_PageMarginsWarning: return "һ�������ϵı߽糬���˴�ӡ��Χ.�Ƿ������";
                case PreviewStringId.Msg_WrongPageSettings: return "��ӡ����֧����ѡ��ֽ�Ŵ�С. �Ƿ������ӡ��";
                case PreviewStringId.Msg_WrongPrinter: return "��Ч�Ĵ�ӡ������.�����ӡ���������Ƿ���ȷ.";
                case PreviewStringId.PageInfo_PageDate: return "[Date Printed]";
                case PreviewStringId.PageInfo_PageNumber: return "[Page #]";
                case PreviewStringId.PageInfo_PageNumberOfTotal: return "[Page # of Pages #]";
                case PreviewStringId.PageInfo_PageTime: return "[Time Printed]";
                case PreviewStringId.PageInfo_PageUserName: return "[User Name]";
                case PreviewStringId.PreviewForm_Caption: return "Ԥ��";
                case PreviewStringId.SaveDlg_FilterBmp: return "BMP Bitmap Format";
                case PreviewStringId.SaveDlg_FilterCsv: return "CSV�ļ�";
                case PreviewStringId.SaveDlg_FilterGif: return "GIF Graphics Interchange Format";
                case PreviewStringId.SaveDlg_FilterHtm: return "HTML�ļ�";
                case PreviewStringId.SaveDlg_FilterJpeg: return "JPEG File Interchange Format";
                case PreviewStringId.SaveDlg_FilterMht: return "MHT�ļ�";
                case PreviewStringId.SaveDlg_FilterPdf: return "PDF�ļ�";
                case PreviewStringId.SaveDlg_FilterPng: return "PNG Portable Network Graphics Format";
                case PreviewStringId.SaveDlg_FilterRtf: return "RTF�ļ�";
                case PreviewStringId.SaveDlg_FilterTiff: return "TIFF Tag Image File Format";
                case PreviewStringId.SaveDlg_FilterTxt: return "TXT�ļ�";
                case PreviewStringId.SaveDlg_FilterWmf: return "WMF Windows Metafile";
                case PreviewStringId.SaveDlg_FilterXls: return "Excel�ļ�";
                case PreviewStringId.SaveDlg_Title: return "����Ϊ";
                //case PreviewStringId.SB_CurrentPageNo: return "Ŀǰҳ��:";
                case PreviewStringId.SB_PageOfPages: return "Ŀǰҳ��:";
                case PreviewStringId.SB_PageInfo: return "{0}/{1}";
                //case PreviewStringId.SB_PageNone: return "��";
                //case PreviewStringId.SB_TotalPageNo: return "��ҳ��:";
                case PreviewStringId.SB_ZoomFactor: return "����ϵ��:";
                case PreviewStringId.ScrollingInfo_Page: return "ҳ";
                case PreviewStringId.TB_TTip_Backgr: return "����ɫ";
                case PreviewStringId.TB_TTip_Close: return "�˳�";
                case PreviewStringId.TB_TTip_Customize: return "�Զ���";
                case PreviewStringId.TB_TTip_EditPageHF: return "ҳüҳ��";
                case PreviewStringId.TB_TTip_Export: return "�����ļ�";
                case PreviewStringId.TB_TTip_FirstPage: return "��ҳ";
                case PreviewStringId.TB_TTip_HandTool: return "���ƹ���";
                case PreviewStringId.TB_TTip_LastPage: return "βҳ";
                case PreviewStringId.TB_TTip_Magnifier: return "�Ŵ�/��С";
                case PreviewStringId.TB_TTip_Map: return "�ĵ���ͼ";
                case PreviewStringId.TB_TTip_MultiplePages: return "��ҳ";
                case PreviewStringId.TB_TTip_NextPage: return "��һҳ";
                case PreviewStringId.TB_TTip_PageSetup: return "ҳ������";
                case PreviewStringId.TB_TTip_PreviousPage: return "��һҳ";
                case PreviewStringId.TB_TTip_Print: return "��ӡ";
                case PreviewStringId.TB_TTip_PrintDirect: return "ֱ�Ӵ�ӡ";
                case PreviewStringId.TB_TTip_Search: return "����";
                case PreviewStringId.TB_TTip_Send: return "����E-Mail";
                case PreviewStringId.TB_TTip_Watermark: return "ˮӡ";
                case PreviewStringId.TB_TTip_Zoom: return "����";
                case PreviewStringId.TB_TTip_ZoomIn: return "�Ŵ�";
                case PreviewStringId.TB_TTip_ZoomOut: return "��С";
                case PreviewStringId.WMForm_Direction_BackwardDiagonal: return "������б";
                case PreviewStringId.WMForm_Direction_ForwardDiagonal: return "������б";
                case PreviewStringId.WMForm_Direction_Horizontal: return "����";
                case PreviewStringId.WMForm_Direction_Vertical: return "����";
                case PreviewStringId.WMForm_HorzAlign_Center: return "����";
                case PreviewStringId.WMForm_HorzAlign_Left: return "����";
                case PreviewStringId.WMForm_HorzAlign_Right: return "����";
                case PreviewStringId.WMForm_ImageClip: return "����";
                case PreviewStringId.WMForm_ImageStretch: return "��չ";
                case PreviewStringId.WMForm_ImageZoom: return "����";
                case PreviewStringId.WMForm_PageRangeRgrItem_All: return "ȫ��";
                case PreviewStringId.WMForm_PageRangeRgrItem_Pages: return "ҳ��";
                case PreviewStringId.WMForm_PictureDlg_Title: return "ѡ��ͼƬ";
                case PreviewStringId.WMForm_VertAlign_Bottom: return "�׶�";
                case PreviewStringId.WMForm_VertAlign_Middle: return "�м�";
                case PreviewStringId.WMForm_VertAlign_Top: return "����";
                case PreviewStringId.WMForm_Watermark_Asap: return "ASAP";
                case PreviewStringId.WMForm_Watermark_Confidential: return "CONFIDENTIAL";
                case PreviewStringId.WMForm_Watermark_Copy: return "COPY";
                case PreviewStringId.WMForm_Watermark_DoNotCopy: return "DO NOT COPY";
                case PreviewStringId.WMForm_Watermark_Draft: return "DRAFT";
                case PreviewStringId.WMForm_Watermark_Evaluation: return "EVALUATION";
                case PreviewStringId.WMForm_Watermark_Original: return "ORIGINAL";
                case PreviewStringId.WMForm_Watermark_Personal: return "PERSONAL";
                case PreviewStringId.WMForm_Watermark_Sample: return "SAMPLE";
                case PreviewStringId.WMForm_Watermark_TopSecret: return "TOP SECRET";
                case PreviewStringId.WMForm_Watermark_Urgent: return "URGENT";
                case PreviewStringId.WMForm_ZOrderRgrItem_Behind: return "�ں���";
                case PreviewStringId.WMForm_ZOrderRgrItem_InFront: return "��ǰ��";
            }
            return base.GetLocalizedString(id);
        }
    }

    //public class XtraReports_CN : ReportLocalizer
    //{
    //    public override string Language
    //    {
    //        get
    //        {
    //            return "��������";
    //        }
    //    }
    //    public override string GetLocalizedString(ReportStringId id)
    //    {
    //        switch (id)
    //        {
    //            case ReportStringId.BandDsg_QuantityPerPage: return "һ��ҳ�漯��";
    //            case ReportStringId.BandDsg_QuantityPerReport: return "һ����������";
    //            case ReportStringId.BCForm_Lbl_Binding: return "���";
    //            case ReportStringId.BCForm_Lbl_Property: return "����";
    //            case ReportStringId.CatAppearance: return "����";
    //            case ReportStringId.CatBehavior: return "״̬";
    //            case ReportStringId.CatData: return "����";
    //            case ReportStringId.CatLayout: return "����";
    //            case ReportStringId.CatNavigation: return "����";
    //            case ReportStringId.CatPageSettings: return "ҳ������";
    //            case ReportStringId.Cmd_AlignToGrid: return "����������";
    //            case ReportStringId.Cmd_BottomMargin: return "�׶˱�Ե";
    //            case ReportStringId.Cmd_BringToFront: return "�Ƶ����ϲ�";
    //            case ReportStringId.Cmd_Copy: return "����";
    //            case ReportStringId.Cmd_Cut: return "����";
    //            case ReportStringId.Cmd_Delete: return "ɾ��";
    //            case ReportStringId.Cmd_Detail: return "��ϸ";
    //            case ReportStringId.Cmd_DetailReport: return "��ϸ����";
    //            case ReportStringId.Cmd_GroupFooter: return "Ⱥ��β";
    //            case ReportStringId.Cmd_GroupHeader: return "Ⱥ����";
    //            case ReportStringId.Cmd_InsertBand: return "��������";
    //            case ReportStringId.Cmd_InsertDetailReport: return "������ϸ����";
    //            case ReportStringId.Cmd_InsertUnboundDetailReport: return "�ǰ�";
    //            case ReportStringId.Cmd_PageFooter: return "ҳβ";
    //            case ReportStringId.Cmd_PageHeader: return "ҳ��";
    //            case ReportStringId.Cmd_Paste: return "ճ��";
    //            case ReportStringId.Cmd_Properties: return "����";
    //            case ReportStringId.Cmd_ReportFooter: return "����β";
    //            case ReportStringId.Cmd_ReportHeader: return "������";
    //            case ReportStringId.Cmd_RtfClear: return "���";
    //            case ReportStringId.Cmd_RtfLoad: return "�����ļ�";
    //            case ReportStringId.Cmd_SendToBack: return "�Ƶ����²�";
    //            case ReportStringId.Cmd_TableDelete: return "ɾ��(&L)";
    //            case ReportStringId.Cmd_TableDeleteCell: return "��Ԫ��(&L)";
    //            case ReportStringId.Cmd_TableDeleteColumn: return "��(&C)";
    //            case ReportStringId.Cmd_TableDeleteRow: return "��(&R)";
    //            case ReportStringId.Cmd_TableInsert: return "����(&I)";
    //            case ReportStringId.Cmd_TableInsertCell: return "��Ԫ��(&C)";
    //            case ReportStringId.Cmd_TableInsertColumnToLeft: return "����(&L)";
    //            case ReportStringId.Cmd_TableInsertColumnToRight: return "����(&R)";
    //            case ReportStringId.Cmd_TableInsertRowAbove: return "����(&A)";
    //            case ReportStringId.Cmd_TableInsertRowBelow: return "����(&B)";
    //            case ReportStringId.Cmd_TopMargin: return "���˱�Ե";
    //            case ReportStringId.Cmd_ViewCode: return "���Ӵ���";
    //            case ReportStringId.FindForm_Msg_FinishedSearching: return "�����ļ����";
    //            case ReportStringId.FindForm_Msg_TotalFound: return "�ϼƲ���:";
    //            case ReportStringId.FSForm_Btn_Delete: return "ɾ��";
    //            case ReportStringId.FSForm_GrBox_Sample: return "����";
    //            case ReportStringId.FSForm_Lbl_Category: return "���";
    //            case ReportStringId.FSForm_Lbl_CustomGeneral: return "һ���ʽ�������������ָ�ʽ";
    //            case ReportStringId.FSForm_Lbl_Prefix: return "�ϱ�";
    //            case ReportStringId.FSForm_Lbl_Suffix: return "�±�";
    //            case ReportStringId.FSForm_Msg_BadSymbol: return "�𻵵ķ���";
    //            case ReportStringId.FSForm_Tab_Custom: return "�Զ���";
    //            case ReportStringId.FSForm_Tab_StandardTypes: return "��׼����";
    //            case ReportStringId.Msg_CantFitBarcodeToControlBounds: return "������ؼ��ı߽�̫С";
    //            case ReportStringId.Msg_CreateReportInstance: return "����ͼ��һ����ͬ���͵ı������༭���Ƿ�ȷ������ʵ����";
    //            case ReportStringId.Msg_CreateSomeInstance: return "�ڴ����в��ܽ�������ʵ���ࡣ";
    //            case ReportStringId.Msg_CyclicBoormarks: return "����ѭ����ǩ";
    //            case ReportStringId.Msg_DontSupportMulticolumn: return "��ϸ������֧�ֶ��ֶΡ�";
    //            case ReportStringId.Msg_FileCorrupted: return "���ܼ��ر������ļ����ܱ��ƻ����߱��������ʧ��";
    //            case ReportStringId.Msg_FileNotFound: return "�ļ�û���ҵ�";
    //            case ReportStringId.Msg_FillDataError: return "���ݼ���ʱ�������󡣴���Ϊ��";
    //            case ReportStringId.Msg_IncorrectArgument: return "����ֵ���벻��ȷ";
    //            case ReportStringId.Msg_IncorrectBandType: return "��Ч�Ĵ���";
    //            case ReportStringId.Msg_InvalidBarcodeText: return "���ı�������Ч���ַ�";
    //            case ReportStringId.Msg_InvalidBarcodeTextFormat: return "��Ч���ı���ʽ";
    //            case ReportStringId.Msg_InvalidMethodCall: return "����ĵ�ǰ״̬�²��ܵ��ô˷���";
    //            case ReportStringId.Msg_InvalidReportSource: return "�޷�����ԭ����";
    //            case ReportStringId.Msg_InvPropName: return "��Ч��������";
    //            case ReportStringId.Msg_ScriptError: return "�ڽű��з��ִ��� {0}";
    //            case ReportStringId.Msg_ScriptExecutionError: return "�ڽű�ִ�й����з��ִ��� {0}:  {1} ���� {0} �����У��������ٱ����á�";
    //            case ReportStringId.Msg_WrongReportClassName: return "һ���������ڲ��л��ڼ� - �����Ǳ�����������";
    //            case ReportStringId.MultiColumnDesignMsg1: return "�ظ���֮��Ŀ�λ";
    //            case ReportStringId.MultiColumnDesignMsg2: return "�ؼ�λ�ò���ȷ�����ᵼ�´�ӡ����";
    //            case ReportStringId.PanelDesignMsg: return "�ڴ˿ɷ��ò�ͬ�ؼ�";
    //            case ReportStringId.RepTabCtl_Designer: return "���";
    //            case ReportStringId.RepTabCtl_HtmlView: return "HTML��ͼ";
    //            case ReportStringId.RepTabCtl_Preview: return "Ԥ��";
    //            case ReportStringId.SSForm_Btn_Close: return "�ر�";
    //            case ReportStringId.SSForm_Caption: return "ʽ�����༭";
    //            case ReportStringId.SSForm_Msg_FileFilter: return "Report StyleSheet files (*.repss)|*.repss|All files (*.*)|*.*";
    //            case ReportStringId.SSForm_Msg_InvalidFileFormat: return "��Ч���ļ���ʽ";
    //            case ReportStringId.SSForm_Msg_MoreThanOneStyle: return "��ѡ���˶��һ�����ϵ�ʽ��";
    //            case ReportStringId.SSForm_Msg_NoStyleSelected: return "û��ʽ����ѡ��";
    //            case ReportStringId.SSForm_Msg_SelectedStylesText: return "��ѡ�е�ʽ��";
    //            case ReportStringId.SSForm_Msg_StyleNamePreviewPostfix: return "ʽ��";
    //            case ReportStringId.SSForm_Msg_StyleSheetError: return "StyleSheet����";
    //            case ReportStringId.SSForm_TTip_AddStyle: return "����ʽ��";
    //            case ReportStringId.SSForm_TTip_ClearStyles: return "���ʽ��";
    //            case ReportStringId.SSForm_TTip_LoadStyles: return "���ļ��ж���ʽ��";
    //            case ReportStringId.SSForm_TTip_PurgeStyles: return "���ʽ��";
    //            case ReportStringId.SSForm_TTip_RemoveStyle: return "�Ƴ�ʽ��";
    //            case ReportStringId.SSForm_TTip_SaveStyles: return "����ʽ�����ļ�";
    //            case ReportStringId.UD_FormCaption: return "XtraReport���";
    //            case ReportStringId.UD_Msg_ReportChanged: return "���������ѱ��޸ģ��Ƿ���Ҫ���棿";
    //            case ReportStringId.UD_ReportDesigner: return "XtraReport���";
    //            case ReportStringId.UD_TTip_AlignBottom: return "�������������Ե";
    //            case ReportStringId.UD_TTip_AlignHorizontalCenters: return "����������Ĵ�ֱ�м�";
    //            case ReportStringId.UD_TTip_AlignLeft: return "�������������Ե";
    //            case ReportStringId.UD_TTip_AlignRight: return "�������������Ե";
    //            case ReportStringId.UD_TTip_AlignToGrid: return "����������";
    //            case ReportStringId.UD_TTip_AlignTop: return "�������������Ե";
    //            case ReportStringId.UD_TTip_AlignVerticalCenters: return "�����������ˮƽ����";
    //            case ReportStringId.UD_TTip_BringToFront: return "�Ƶ����ϲ�";
    //            case ReportStringId.UD_TTip_CenterHorizontally: return "ˮƽ����";
    //            case ReportStringId.UD_TTip_CenterVertically: return "��ֱ����";
    //            case ReportStringId.UD_TTip_EditCopy: return "����";
    //            case ReportStringId.UD_TTip_EditCut: return "����";
    //            case ReportStringId.UD_TTip_EditPaste: return "ճ��";
    //            case ReportStringId.UD_TTip_FileOpen: return "���ļ�";
    //            case ReportStringId.UD_TTip_FileSave: return "�����ļ�";
    //            case ReportStringId.UD_TTip_FormatAlignLeft: return "�����";
    //            case ReportStringId.UD_TTip_FormatAlignRight: return "�Ҷ���";
    //            case ReportStringId.UD_TTip_FormatBackColor: return "������ɫ";
    //            case ReportStringId.UD_TTip_FormatBold: return "����";
    //            case ReportStringId.UD_TTip_FormatCenter: return "����";
    //            case ReportStringId.UD_TTip_FormatFontName: return "����";
    //            case ReportStringId.UD_TTip_FormatFontSize: return "��С";
    //            case ReportStringId.UD_TTip_FormatForeColor: return "ǰ����ɫ";
    //            case ReportStringId.UD_TTip_FormatItalic: return "б��";
    //            case ReportStringId.UD_TTip_FormatJustify: return "���˶���";
    //            case ReportStringId.UD_TTip_FormatUnderline: return "�»���";
    //            case ReportStringId.UD_TTip_HorizSpaceConcatenate: return "�Ƴ�ˮƽ���";
    //            case ReportStringId.UD_TTip_HorizSpaceDecrease: return "����ˮƽ���";
    //            case ReportStringId.UD_TTip_HorizSpaceIncrease: return "����ˮƽ���";
    //            case ReportStringId.UD_TTip_HorizSpaceMakeEqual: return "����ֱ�����Ϊ���";
    //            case ReportStringId.UD_TTip_Redo: return "�ָ�";
    //            case ReportStringId.UD_TTip_SendToBack: return "�Ƶ����²�";
    //            case ReportStringId.UD_TTip_SizeToControl: return "���ó���ͬ��С";
    //            case ReportStringId.UD_TTip_SizeToControlHeight: return "���ó���ͬ�߶�";
    //            case ReportStringId.UD_TTip_SizeToControlWidth: return "���ó���ͬ����";
    //            case ReportStringId.UD_TTip_SizeToGrid: return "�������ߵ�����С";
    //            case ReportStringId.UD_TTip_Undo: return "����";
    //            case ReportStringId.UD_TTip_VertSpaceConcatenate: return "�Ƴ���ֱ���";
    //            case ReportStringId.UD_TTip_VertSpaceDecrease: return "���ٴ�ֱ���";
    //            case ReportStringId.UD_TTip_VertSpaceIncrease: return "���Ӵ�ֱ���";
    //            case ReportStringId.UD_TTip_VertSpaceMakeEqual: return "����ֱ�����Ϊ���";
    //        }
    //        return base.GetLocalizedString(id);
    //    }
    //}

    public class XtraTreeList_CN : TreeListLocalizer
    {
        public override string Language
        {
            get
            {
                return "��������";
            }
        }
        public override string GetLocalizedString(TreeListStringId id)
        {
            switch (id)
            {
                case TreeListStringId.ColumnCustomizationText: return "�Զ���ʾ�ֶ�";
                case TreeListStringId.ColumnNamePrefix: return "�����ױ�";
                case TreeListStringId.InvalidNodeExceptionText: return "�Ƿ�ȷ��Ҫ�޸�?";
                case TreeListStringId.MenuColumnBestFit: return "���ƥ��";
                case TreeListStringId.MenuColumnBestFitAllColumns: return "���ƥ��(������)";
                case TreeListStringId.MenuColumnColumnCustomization: return "��ѡ��";
                case TreeListStringId.MenuColumnSortAscending: return "��������";
                case TreeListStringId.MenuColumnSortDescending: return "��������";
                case TreeListStringId.MenuFooterAllNodes: return "ȫ���ڵ�";
                case TreeListStringId.MenuFooterAverage: return "ƽ��";
                case TreeListStringId.MenuFooterAverageFormat: return "ƽ��ֵ={0:#.##}";
                case TreeListStringId.MenuFooterCount: return "����";
                case TreeListStringId.MenuFooterCountFormat: return "{0}";
                case TreeListStringId.MenuFooterMax: return "���ֵ";
                case TreeListStringId.MenuFooterMaxFormat: return "���ֵ={0}";
                case TreeListStringId.MenuFooterMin: return "��Сֵ";
                case TreeListStringId.MenuFooterMinFormat: return "��Сֵ={0}";
                case TreeListStringId.MenuFooterNone: return "��";
                case TreeListStringId.MenuFooterSum: return "�ϼ�";
                case TreeListStringId.MenuFooterSumFormat: return "�ϼ�={0:#.##}";
                case TreeListStringId.MultiSelectMethodNotSupported: return "OptionsBehavior.MultiSelectδ����ʱ��ָ���������ܹ���.";
                case TreeListStringId.PrintDesignerDescription: return "Ϊ��ǰ����״�б����ò�ͬ�Ĵ�ӡѡ��.";
                case TreeListStringId.PrintDesignerHeader: return "��ӡ����";
            }
            return base.GetLocalizedString(id);
        }
    }

    public class XtraVerticalGrid_CN : VGridLocalizer
    {
        public override string Language
        {
            get
            {
                return "��������";
            }
        }
        public override string GetLocalizedString(VGridStringId id)
        {
            switch (id)
            {
                case VGridStringId.InvalidRecordExceptionText: return "�Ƿ�ȷ���޸�?";
                case VGridStringId.RowCustomizationDeleteCategoryText: return "ɾ��";
                case VGridStringId.RowCustomizationNewCategoryFormLabelText: return "����";
                case VGridStringId.RowCustomizationNewCategoryFormText: return "�������";
                case VGridStringId.RowCustomizationNewCategoryText: return "����";
                case VGridStringId.RowCustomizationTabPageCategoriesText: return "���";
                case VGridStringId.RowCustomizationTabPageRowsText: return "��";
                case VGridStringId.RowCustomizationText: return "�Զ���";
                case VGridStringId.StyleCreatorName: return "�Զ���ʽ��";
            }
            return base.GetLocalizedString(id);
        }
    }
    public class XtraLayout_CN : DevExpress.XtraLayout.Localization.LayoutLocalizer
    {
        public override string Language
        {
            get
            {
                return "��������";
            }
        }
        public override string GetLocalizedString(LayoutStringId id)
        {
            switch (id)
            {
                case LayoutStringId.AddTabMenuText: return "���ӱ�ǩҳ";
                case LayoutStringId.ControlGroupDefaultText: return "Ⱥ��";
                case LayoutStringId.CreateEmptySpaceItem: return "�����հ�������Ŀ";
                case LayoutStringId.CreateTabbedGroupMenuText: return "����Ⱥ���ǩҳ";
                case LayoutStringId.CustomizationFormTitle: return "����";
                case LayoutStringId.CustomizationParentName: return "����";
                case LayoutStringId.DefaultActionText: return "Ĭ�϶���";
                case LayoutStringId.DefaultEmptyText: return "��";
                case LayoutStringId.DefaultItemText: return "��Ŀ";
                case LayoutStringId.EmptyRootGroupText: return "��������ÿؼ�";
                case LayoutStringId.EmptySpaceItemDefaultText: return "�հ�������Ŀ";
                case LayoutStringId.EmptyTabbedGroupText: return "��Ⱥ���Ϸŵ�Ⱥ���ǩҳ����";
                case LayoutStringId.FreeSizingMenuItem: return "�����ı��С";
                case LayoutStringId.GroupItemsMenuText: return "Ⱥ��";
                case LayoutStringId.HiddenItemsPageTitle: return "������Ŀ";
                case LayoutStringId.HideCustomizationFormMenuText: return "���ض��Ʊ���";
                case LayoutStringId.HideItemMenutext: return "������Ŀ";
                case LayoutStringId.HideTextMenuItem: return "�����ı�";
                case LayoutStringId.LayoutControlDescription: return "�������";
                case LayoutStringId.LayoutGroupDescription: return "������ƿ�������Ⱥ��Ԫ��";
                case LayoutStringId.LayoutItemDescription: return "������ƿ���������ĿԪ��";
                case LayoutStringId.LockHeightMenuItem: return "�����߶�";
                case LayoutStringId.LockItemSizeMenuText: return "������Ŀ��С";
                case LayoutStringId.LockMenuGroup: return "ǿ���޶���С";
                case LayoutStringId.LockSizeMenuItem: return "������С";
                case LayoutStringId.LockWidthMenuItem: return "��������";
                case LayoutStringId.RenameMenuText: return "������";
                case LayoutStringId.RenameSelected: return "������";
                case LayoutStringId.ResetConstraintsToDefaultsMenuItem: return "����ΪĬ��ֵ";
                case LayoutStringId.ResetLayoutMenuText: return "�������";
                case LayoutStringId.ShowCustomizationFormMenuText: return "���ư���";
                case LayoutStringId.ShowTextMenuItem: return "��ʾ�ı�";
                case LayoutStringId.SplitterItemDefaultText: return "�ָ��������OӋ��������Ⱥ�M�˻`��Ŀ";
                case LayoutStringId.TabbedGroupDescription: return "�����������Ⱥ���ǩҳԪ��";
                case LayoutStringId.TextPositionBottomMenuText: return "�·�";
                case LayoutStringId.TextPositionLeftMenuText: return "���";
                case LayoutStringId.TextPositionMenuText: return "�ı�λ��";
                case LayoutStringId.TextPositionRightMenuText: return "�ұ�";
                case LayoutStringId.TextPositionTopMenuText: return "�Ϸ�";
                case LayoutStringId.TreeViewPageTitle: return "���������״��ͼ";
                case LayoutStringId.TreeViewRootNodeName: return "���ϲ�";
                case LayoutStringId.UnGroupItemsMenuText: return "���Ⱥ���趨";
                case LayoutStringId.UnGroupTabbedGroupMenuText: return "���Ⱥ���ǩҳ�趨";
                case LayoutStringId.UnLockItemSizeMenuText: return "�����Ŀ��С����";
            }
            return base.GetLocalizedString(id);
        }
    }
}