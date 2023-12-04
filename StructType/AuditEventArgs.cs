using System;
namespace Banking
{
	public class AuditEventArgs : EventArgs

	{
        private readonly BankTransaction thansData = null;


        public AuditEventArgs(BankTransaction transaction)
		{
			thansData = transaction;
		}

		public BankTransaction getTransaction ()
		{
			return thansData;
		}
	}
}

