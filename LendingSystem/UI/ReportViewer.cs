using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace LendingSystem.UI
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }


        public void ScheduleOfPayment(Int64 LoanId, bool Preview)
        {

            string exePath = Application.StartupPath;
            exePath = exePath + "\\Reports\\ScheduleOfPayment.rpt";
            //Instantiate variables
            ReportDocument reportDocument = new ReportDocument();
            ParameterField paramField = new ParameterField();
            ParameterFields paramFields = new ParameterFields();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //Set instances for input parameter 1 -  @vDepartment
            paramField.Name = "@LoanId";
            paramDiscreteValue.Value = LoanId;
            paramField.CurrentValues.Add(paramDiscreteValue);
            //Add the paramField to paramFields
            paramFields.Add(paramField);
            crvReports.ParameterFieldInfo = paramFields;
            reportDocument.Load(@exePath);


            foreach (CrystalDecisions.Shared.IConnectionInfo connection in reportDocument.DataSourceConnections)
            {
                connection.IntegratedSecurity = false;
                for (int i = 0; i < reportDocument.DataSourceConnections.Count; i++)
                {
                    reportDocument.DataSourceConnections[i].SetConnection("SERVER85", "Lending", "sa", "admin");
                }
            }


            if (Preview == true)
            {
                crvReports.ReportSource = reportDocument;
            }
            else
            {
                crvReports.ReportSource = reportDocument;
                crvReports.PrintReport();
            }

        }



        public void LedgerPrint(Int64 LoanId, bool Preview)
        {
            string exePath = Application.StartupPath;
            exePath = exePath + "\\Reports\\LedgerPrint.rpt";
            //Instantiate variables
            ReportDocument reportDocument = new ReportDocument();
            ParameterField paramField = new ParameterField();
            ParameterFields paramFields = new ParameterFields();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //Set instances for input parameter 1 -  @vDepartment
            paramField.Name = "@LoanId";
            paramDiscreteValue.Value = LoanId;
            paramField.CurrentValues.Add(paramDiscreteValue);
            //Add the paramField to paramFields
            paramFields.Add(paramField);
            crvReports.ParameterFieldInfo = paramFields;
            reportDocument.Load(@exePath);


            foreach (CrystalDecisions.Shared.IConnectionInfo connection in reportDocument.DataSourceConnections)
            {
                connection.IntegratedSecurity = false;
                for (int i = 0; i < reportDocument.DataSourceConnections.Count; i++)
                {
                    reportDocument.DataSourceConnections[i].SetConnection("SERVER85", "Lending", "sa", "admin");
                }
            }


            if (Preview == true)
            {
                crvReports.ReportSource = reportDocument;
            }
            else
            {
                crvReports.ReportSource = reportDocument;
                crvReports.PrintReport();
            }

        }


        public void AgingOfReceivable(DateTime DateAsOf, bool Preview)
        {
            string exePath = Application.StartupPath;
            exePath = exePath + "\\Reports\\AgingOfReceivable.rpt";
            //Instantiate variables
            ReportDocument reportDocument = new ReportDocument();
            ParameterField paramField = new ParameterField();
            ParameterFields paramFields = new ParameterFields();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //Set instances for input parameter 1 -  @vDepartment
            paramField.Name = "@DateAsOf";
            paramDiscreteValue.Value = DateAsOf;
            paramField.CurrentValues.Add(paramDiscreteValue);
            //Add the paramField to paramFields
            paramFields.Add(paramField);
            crvReports.ParameterFieldInfo = paramFields;
            reportDocument.Load(@exePath);

            foreach (CrystalDecisions.Shared.IConnectionInfo connection in reportDocument.DataSourceConnections)
            {
                connection.IntegratedSecurity = false;
                for (int i = 0; i < reportDocument.DataSourceConnections.Count; i++)
                {
                    reportDocument.DataSourceConnections[i].SetConnection("SERVER85", "Lending", "sa", "admin");
                    //  reportDocument.DataSourceConnections[i].SetConnection(Variables.ServerName, Variables.DBName, Variables.UserName, Variables.Password);
                }
            }


            if (Preview == true)
            {
                crvReports.ReportSource = reportDocument;
            }
            else
            {
                crvReports.ReportSource = reportDocument;
                crvReports.PrintReport();
            }

        }

        public void AgingOfReceivableToday( bool Preview)
        {
            string exePath = Application.StartupPath;
            exePath = exePath + "\\Reports\\AgingOfReceivableToday.rpt";
            //Instantiate variables
            ReportDocument reportDocument = new ReportDocument();
            ParameterField paramField = new ParameterField();
            ParameterFields paramFields = new ParameterFields();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            reportDocument.Load(@exePath);

            foreach (CrystalDecisions.Shared.IConnectionInfo connection in reportDocument.DataSourceConnections)
            {
                connection.IntegratedSecurity = false;
                for (int i = 0; i < reportDocument.DataSourceConnections.Count; i++)
                {
                    reportDocument.DataSourceConnections[i].SetConnection("SERVER85", "Lending", "sa", "admin");
                    //  reportDocument.DataSourceConnections[i].SetConnection(Variables.ServerName, Variables.DBName, Variables.UserName, Variables.Password);
                }
            }


            if (Preview == true)
            {
                crvReports.ReportSource = reportDocument;
            }
            else
            {
                crvReports.ReportSource = reportDocument;
                crvReports.PrintReport();
            }

        }

        public void AgingOfReceivableByOffice(bool Preview)
        {
            string exePath = Application.StartupPath;
            exePath = exePath + "\\Reports\\AgingOfReceivableByOffice.rpt";
            //Instantiate variables
            ReportDocument reportDocument = new ReportDocument();
            ParameterField paramField = new ParameterField();
            ParameterFields paramFields = new ParameterFields();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            ////Set instances for input parameter 1 -  @vDepartment
            //paramField.Name = "@DateAsOf";
            //paramDiscreteValue.Value = DateAsOf;
            //paramField.CurrentValues.Add(paramDiscreteValue);
            ////Add the paramField to paramFields
            //paramFields.Add(paramField);
            //crvReports.ParameterFieldInfo = paramFields;
            reportDocument.Load(@exePath);


            //set the database loggon information. 
            //**Note that the third parameter is the DSN name 
            //  and not the Database or System name
            //  reportDocument.SetDatabaseLogon("pchitriv", "Windows2000",
            //                             "TestDB_DSN", "testDB", false);
            // reportDocument.SetDatabaseLogon(Variables.UserName, Variables.Password, Variables.ServerName, Variables.DBName, false);


            foreach (CrystalDecisions.Shared.IConnectionInfo connection in reportDocument.DataSourceConnections)
            {
                connection.IntegratedSecurity = false;
                for (int i = 0; i < reportDocument.DataSourceConnections.Count; i++)
                {
                    reportDocument.DataSourceConnections[i].SetConnection("SERVER85", "Lending", "sa", "admin");
                    //  reportDocument.DataSourceConnections[i].SetConnection(Variables.ServerName, Variables.DBName, Variables.UserName, Variables.Password);
                }
            }


            if (Preview == true)
            {
                crvReports.ReportSource = reportDocument;
            }
            else
            {
                crvReports.ReportSource = reportDocument;
                crvReports.PrintReport();
            }

        }



        public void PaymentListPrint(DateTime DateFrom, DateTime DateTo, bool Preview)
        {


            string exePath = Application.StartupPath;
            exePath = exePath + "\\Reports\\PaymentList.rpt";
            //Instantiate variables

            ReportDocument reportDocument = new ReportDocument();
            ParameterFields paramFields = new ParameterFields();

            ParameterField paramDateTo = new ParameterField();
            ParameterDiscreteValue paramDateToDiscreteValue = new ParameterDiscreteValue();

            ParameterField paramDateFrom = new ParameterField();
            ParameterDiscreteValue paramDateFromDiscreteValue = new ParameterDiscreteValue();


            //Set instances for input parameter 1 -  @vDepartment
            paramDateFrom.Name = "@DateFrom";
            paramDateFromDiscreteValue.Value = DateFrom;
            paramDateFrom.CurrentValues.Add(paramDateFromDiscreteValue);
            paramFields.Add(paramDateFrom);


            paramDateTo.Name = "@DateTo";
            paramDateToDiscreteValue.Value = DateTo;
            paramDateTo.CurrentValues.Add(paramDateToDiscreteValue);
            paramFields.Add(paramDateTo);


            //Add the paramField to paramFields
           // paramFields.Add(paramField);

            crvReports.ParameterFieldInfo = paramFields;
            reportDocument.Load(@exePath);


            foreach (CrystalDecisions.Shared.IConnectionInfo connection in reportDocument.DataSourceConnections)
            {
                connection.IntegratedSecurity = false;
                for (int i = 0; i < reportDocument.DataSourceConnections.Count; i++)
                {
                    reportDocument.DataSourceConnections[i].SetConnection("SERVER85", "Lending", "sa", "admin");
                }
            }


            if (Preview == true)
            {
                crvReports.ReportSource = reportDocument;
            }
            else
            {
                crvReports.ReportSource = reportDocument;
                crvReports.PrintReport();
            }



        }






    }
}
