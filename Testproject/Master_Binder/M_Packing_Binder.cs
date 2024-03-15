using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public  class M_Packing_Binder
    {
        public M_Packing_Model DataBinder()
        {
            M_Packing_Model model= new M_Packing_Model();
            model.PackingId = 0;
            model.PackingName = "";
            model.FirstPackingConvert = 2;
            model.SecondPackingConvert= 3;
            model.Attr1 = "";
            model.Attr2 = "";

            return model;
        }

    }
}
