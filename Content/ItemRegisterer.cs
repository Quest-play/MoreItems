using System.Collections.Generic;
using GKAPI.Items;

namespace MoreItems.Content;


class ItemRegisterer(ItemAPI api)
{
    private ItemAPI itemAPI = api;
    private List<GkItem> ItemList { get; set; } = [];

    public void Register()
    {
        
    }

    public List<GkItem> getItemList()
    {
        return ItemList;
    }
}