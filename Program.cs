namespace DDFFMPEG2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 form = new Form1();
            form.DragDrop += new DragEventHandler(FileDragDrop);
            Application.Run(form);

        }
            static void FileDragDrop(object sender, DragEventArgs e)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop); 
            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".png")
                {
                    Application.Run(new Form1());
                }
            }

            
            
            }
    }
}