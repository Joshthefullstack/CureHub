using HMSData.DataStore.RecieptStore;
using HMSData.Enum;
using System;

namespace HMSData.Payment
{
    public class BillsAndPayment
    {
        public string BillsAndReceiptId { get; }

        public static int s_BillsId = 12345;
        public string PatientID { get; }
        public PaymentMethod MethodOfPayment { get; set; }
        public int Amount { get; set; }
        public string Narration { get; set; }
        public PaymentStatus Status { get; set; }

        public BillsAndPayment(string patientID, PaymentMethod methodOfPayment, int amount, string narration,
            PaymentStatus billsAndPaymentStatus)
        {
            PatientID = patientID;
            MethodOfPayment = methodOfPayment;
            Amount = amount;
            Narration = narration;
            Status = billsAndPaymentStatus;
            BillsAndReceiptId = s_BillsId.ToString();
            s_BillsId++;

        }

        public string AddReceipt(int totalAmount, string narration,
            PaymentMethod paymentMethod, PaymentStatus paymentStatus)
        {
            if (totalAmount <= 0)
            {
                return "Input a valid total amount";
            }

            Reciept receipt = new Reciept();
            string receiptId = receipt.InitReceipt(paymentMethod, paymentStatus, narration, totalAmount);
            if(receiptId.Length > 0)
            {
                ReceiptDataStore.Reciepts.Add(receipt);
                return receiptId;
            }

            return "";
        }
    }
}
