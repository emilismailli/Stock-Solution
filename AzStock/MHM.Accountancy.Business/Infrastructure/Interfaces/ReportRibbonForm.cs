using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting.Localization;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;

namespace MHM.Accountancy.Business.Infrastructure.Interfaces
{
    public partial class ReportRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ReportRibbonForm(IManager manager,XtraReport report,bool showParameters)
        {
            InitializeComponent();
            docViewer.ShowPageMargins = report.ShowPreviewMarginLines;
            this.Text = (manager as XtraUserControl).Parent.Text;
            docViewer.DocumentSource = report;

            if (!showParameters)
            {
                if (report.PrintingSystem.GetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters) != DevExpress.XtraPrinting.CommandVisibility.None)
                    report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters, DevExpress.XtraPrinting.CommandVisibility.None);
            }
        }

        public ReportRibbonForm(IManager manager, XtraReport report)
            :this(manager,report,false)
        {

        }

        public ReportRibbonForm(IManager manager, XtraReport report,Parameter[] parameters)
            : this(manager, report, false)
        {
            if (parameters != null)
            {
                var doc = docViewer.DocumentSource as XtraReport;
                doc.Parameters.Clear();
                doc.Parameters.AddRange(parameters);
            }
        }

        private void ReportRibbonForm_Load(object sender, EventArgs e)
        {
            ribbonPage.Ribbon.Enabled = true;
            print.Enabled = true;
            //print.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Immediate;
            print.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintSelection;
            printQuick.Enabled = true;
            save.Command = PrintingSystemCommand.Save;
            save.Enabled = true;
            docViewer.Refresh();
            
            PreviewLocalizer.Active = new MHMPreviewLocalizer();


            this.print.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.print_ItemClick);
        }

        private void print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (docViewer.DocumentSource as XtraReport).PrintDialog();



        }

        private void printQuick_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (docViewer.DocumentSource as XtraReport).Print();
        }

        private void exportToDocx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void exportToExcell_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string xlsxExportFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\" + docViewer.Name + ".xlsx";

            docViewer.PrintingSystem.ExportOptions.Xlsx.ExportMode = XlsxExportMode.SingleFile;
            docViewer.PrintingSystem.ExportToXlsx(xlsxExportFile);
        }

       

        private void docViewer_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string docxExportFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\" + docViewer.Name + ".docx";

            docViewer.PrintingSystem.ExportOptions.Docx.ExportMode = DocxExportMode.SingleFile;
            docViewer.PrintingSystem.ExportToDocx(docxExportFile);
        }

        private void btnPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

           
        }
    }

    public class MHMPreviewLocalizer : PreviewLocalizer
    {
        public override string GetLocalizedString(PreviewStringId id)
        {
            switch (id)
            {
                case PreviewStringId.ParametersRequest_Submit:
                    return "Yenilə";
                case PreviewStringId.ParametersRequest_Reset:
                    return "Təmizlə";
                case PreviewStringId.BarText_MainMenu:
                    return "Əsas menu";
                case PreviewStringId.Button_Cancel:
                    return "İmtina";
                case PreviewStringId.EditingFieldEditors_Date:
                    return "Tarix";
                case PreviewStringId.Button_Help:
                    return "Kömək";
                case PreviewStringId.RibbonPreview_Parameters_STipTitle:
                case PreviewStringId.ParametersRequest_Caption:
                    return "Parameterlər";
                case PreviewStringId.Msg_NoParameters:
                    return "Parameter təyin edilməyib: {0}.";
                case PreviewStringId.WaitForm_Caption:
                    return "Gözləyin";
                case PreviewStringId.Msg_CreatingDocument:
                    return "Sənəd hazırlanır...";
                case PreviewStringId.RibbonPreview_PageGroup_PageSetup:
                    return "Səhifə xüsusiyyətləri";
                default:
                    return base.GetLocalizedString(id);
            }                
        }
    }
}