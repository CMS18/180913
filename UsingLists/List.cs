using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLists
{
    class ListItem
    {
        public object data;
        public ListItem next;
    }

    class List
    {
        ListItem first = null;

        public void Add(object item)
        {
            ListItem listItem = new ListItem();
            listItem.data = item;
            listItem.next = first;

            this.first = listItem;

        }

    }
}
