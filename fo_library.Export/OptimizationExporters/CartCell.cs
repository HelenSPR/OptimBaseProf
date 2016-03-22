using Atechnology.winDraw.Classes;
using Atechnology.winDraw.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Export.OptimizationExporters
{
    // Стуктура хранящая значения тележек и ячеек
    internal class CartCell<Item> : IEnumerable<Item>
    {
        public readonly int cartNumber;
        public readonly int cellNumber;
        public readonly string prefixCart;
        public readonly string prefixCell;

        private List<Item> _items = new List<Item>();

        public void Add(Item item)
        {
            _items.Add(item);
        }


        public int Count()
        {
            return _items.Count;
        }

        internal CartCell()
            : this(0, 0, string.Empty, string.Empty)
        {
        }

        internal CartCell(int cartNumber, int cellNumber):this(cartNumber,cellNumber,string.Empty, string.Empty)
        {

        }

     

        internal CartCell(int cartNumber, int cellNumber, string prefixCart, string prefixCell)
        {
            this.cartNumber = cartNumber;
            this.cellNumber = cellNumber;
            this.prefixCart = prefixCart;
            this.prefixCell = prefixCell;
        }

        public string CartNumberString
        {
            get
            {
                return string.Concat(prefixCart, cartNumber);
            }
        }

        public string CellNumberString
        {
            get
            {
                return string.Concat(prefixCell, cellNumber);
            }
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }

   

}
