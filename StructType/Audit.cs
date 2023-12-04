using System;
namespace Banking
{
	public class Audit
	{
		private string fileName;
		private StreamWriter auditFile;

		private bool closed = false;

		public Audit(string fileToUse)
		{
			fileName = fileToUse;
			auditFile = File.AppendText(fileToUse);
		}

		public void RecordTransaction (AuditEventArgs eventData)
		{
			BankTransaction tempTrans = eventData.getTransaction();
			if (tempTrans != null)
				auditFile.WriteLine($"Сумма {tempTrans.TransactionAmount()}" +
					$"Время {tempTrans.When()}");
		}

		public void Close ()
		{
			if (!closed)
			{
				auditFile.Close();
				closed = true;
			}
		}
	}
}

