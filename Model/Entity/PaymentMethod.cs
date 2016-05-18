using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
  public  class Payment
    {
      public PaymentMethod PaymentMethod { get; set; }
      public Boolean Paid { get; set; }
      public int Id { get; set; }
      public string Attachment { get; set; }
    }

    public enum PaymentMethod
    {
        PAYPAL,
        BANK_TRANSFER
    }
}
