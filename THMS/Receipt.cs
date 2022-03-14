using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;

namespace THMS
{
    public class receipt
    {
        PrintDocument pdoc = null;
        int receiptno, hostelid, roomno;
        DateTime receiptDate;
        String studentname, regno, DrawnBy, hostelname, occupancy;
        float Amount;

        public int Receiptno
        {
            //set the person name
            set { this.receiptno = value; }
            //get the person name 
            get { return this.receiptno; }
        }
        public int Roomno
        {
            //set the person name
            set { this.roomno = value; }
            //get the person name 
            get { return this.roomno; }
        }
        public string Occupancy
        {
            //set the person name
            set { this.occupancy = value; }
            //get the person name 
            get { return this.occupancy; }
        }
        public int Hostelid
        {
            //set the person name
            set { this.hostelid = value; }
            //get the person name 
            get { return this.hostelid; }
        }
        public DateTime ReceiptDate
        {
            //set the person name
            set { this.receiptDate = value; }
            //get the person name 
            get { return this.receiptDate; }
        }

        public String Studentname
        {
            //set the person name
            set { this.studentname = value; }
            //get the person name 
            get { return this.studentname; }
        }
        public String Hostelname
        {
            //set the person name
            set { this.hostelname = value; }
            //get the person name 
            get { return this.hostelname; }
        }
        public String Regno
        {
            //set the person name
            set { this.regno = value; }
            //get the person name 
            get { return this.regno; }
        }
        public float amount
        {
            //set the person name
            set { this.Amount = value; }
            //get the person name 
            get { return this.Amount; }
        }
        public String drawnBy
        {
            //set the person name
            set { this.DrawnBy = value; }
            //get the person name 
            get { return this.DrawnBy; }
        }

        public receipt()
        {

        }
        public receipt(int receiptno, int roomno, int hostelid, string occupancy, string hostelname, DateTime receiptDate, String studentname, String regno, float Amount, String DrawnBy)
        {
            this.receiptno = receiptno;
            this.roomno = roomno;
            this.receiptDate = receiptDate;
            this.studentname = studentname;
            this.hostelid = hostelid;
            this.hostelname = hostelname;
            this.regno = regno;
            this.occupancy = occupancy;
            this.Amount = Amount;
            this.DrawnBy = DrawnBy;
        }
        public void print()
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);


            PaperSize psize = new PaperSize("Custom", 100, 200);
            //ps.DefaultPageSettings.PaperSize = psize;



            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;
            pdoc.DefaultPageSettings.PaperSize.Height = 820;

            pdoc.DefaultPageSettings.PaperSize.Width = 520;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = pdoc;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }

        }
        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 55;
            int Offset = 40;
            graphics.DrawString("TURING HOSTEL MANAGEMENT SYSTEM", new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("P.O. BOX 0000, CHUKA TEL.020123456", new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            String underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Receipt No:       r00" + this.receiptno, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Receipt Date:      " + this.receiptDate, new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Student Name:     " + this.studentname, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Registration No: " + this.regno, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Hostel Id:        " + this.Hostelid, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Hostel Name:      " + this.hostelname, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Room No.:      " + this.roomno, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Occupancy:        " + this.occupancy, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            String Grosstotal = "Total Amount Paid = " + this.amount;

            Offset = Offset + 20;
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString(Grosstotal, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            String DrawnBy = this.drawnBy;
            graphics.DrawString("Served by - " +this.drawnBy, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);





        }
    }

}
