using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliak_UI_WT.Domain.Models
{
    public class ListModel<T>
    {
        public List<T> Items { get; set; } = new();
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; } = 1;

        public ListModel() { }
        public ListModel(List<T> items, int currentPage, int totalPages) : this()
        {
            Items = items;
            CurrentPage = currentPage;
            TotalPages = totalPages;
        }

        public override string ToString()
        {
            string str = $"ListModel: Count items - {Items.Count}. " +
                $"Current Page - {CurrentPage}. Total Pages - {TotalPages}.";
            return str;
        }
    }
}
