using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MTO;
using MTO.Models;

namespace MTO.Utils
{
    class BigDataGenerator
    {
        private MTOContext db;

        public BigDataGenerator(MTOContext db)
        {
            this.db = db;
        }

        public bool generateContracts()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        public bool generateDictionaries()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        public bool generate()
        {
            return true;
        }
    }
}
