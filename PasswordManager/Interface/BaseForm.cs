/****************************************************************************
 *                                                                          *
 *  File:        BaseForm.cs                                                *
 *  Copyright:   (c) 2022, Tarziu Matei-Stefan                              *
 *  E-mail:      matei-stefan.tarziu@student.tuiasi.ro                      *
 *  Description: In this file you will find the implementation for          *
 *               a BaseForm class which will have the adequate              *
 *               properties for all the Forms used in the application       *
 *               to inherit.                                                *
 *                                                                          *
 ****************************************************************************/

using System.Windows.Forms;

namespace Interface
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
