using Microsoft.Reporting.WinForms;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using WebDolomit.Models;
using WebDolomit.Repositories;

namespace WebDolomit.Controllers
{
    [AllowAnonymous]
    public class ReportController : Controller
    {
        private DataManager dataManager;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public ReportController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public FileContentResult SaveReport(DateTime date)
        {
            try
            {
                LocalReport report = new LocalReport();
                ReportDataSource rds = new ReportDataSource();

                string path = Path.Combine(Server.MapPath(@"~/bin/ReportBuilder"), "Report.rdlc");
                List<Data> results = dataManager.ILogic.GetDataForReport(date);
                if (System.IO.File.Exists(path))
                {
                    report.ReportPath = path;
                }
                report.DataSources.Add(rds);
                rds.Name = "DataSetData";
                rds.Value = results;
                ReportParameter dateParameter = new ReportParameter();
                dateParameter = new ReportParameter("DateParameter", date.ToString("MMMM yyyy"));
                report.SetParameters(dateParameter);
                string reportType = "excel";
                string mimeType;
                string encoding;
                string fileNameExtension;
                string deviceInfo = "<DeviceInfo>" +
                   "  <OutputFormat>jpeg</OutputFormat>" +
                   //"  <PageWidth>6in</PageWidth>" +
                   //"  <PageHeight>8in</PageHeight>" +
                   //"  <MarginTop>0.5cm</MarginTop>" +
                   //"  <MarginLeft>1.8cm</MarginLeft>" +
                   //"  <MarginRight>0.5in</MarginRight>" +
                   //"  <MarginBottom>0.5in</MarginBottom>" +
                   "</DeviceInfo>";
                Warning[] warnings;
                string[] streams;
                byte[] renderedBytes;
                renderedBytes = report.Render(
                    reportType,
                    deviceInfo,
                    out mimeType,
                    out encoding,
                    out fileNameExtension,
                    out streams,
                    out warnings);
                logger.Info("Save Report");
                return File(renderedBytes, mimeType, "Обеспечение ОАО Доломит.xls");
            }
            catch (Exception ex)
            {
                string msg = string.Format("{0}\n{1}\n{2}", ex.Message, ex.InnerException, ex.Source);
                logger.Error(msg);
                using (MemoryStream stream = new MemoryStream())
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(msg);
                        writer.Flush();
                        stream.Position = 0;

                        return File(stream.ToArray(), "text/plain", "exception.txt");
                    }
                }
            }
        }
    }
}