using System;
namespace ItemInfo
{
    class ItemSelcSort
{
static public void Sort<T>(IList<T> SelcSort, Func<T, T, bool>
comparison)
{
for (int i = 0; i < SelcSort.Count - 1; i++)
{
int key = i;
for (int j = i + 1; j < SelcSort.Count; j++)
{
if (comparison(SelcSort[j], SelcSort[key]))
{
key = j;
}
}
T temp = SelcSort[i];
SelcSort[i] = SelcSort[key];
SelcSort[key] = temp;
}
}
}
    public enum ItemType
    {
        Cotton=1, Nylon=2, Cordroy=3, Polyester=4,
        Woolen=5
    }
    class Item
    {
        int ItemNo;
        public float Cost;
        public string Name;
        public ItemType itemType;
        public Item(int itemNo, float cost, string name, ItemType itype)
        {
            this.ItemNo = itemNo;
            this.Cost = cost;
            this.Name = name;
            this.itemType = itype;
        }
        internal static bool CompareCost(Item i1, Item i2)
        {
            return i1.Cost < i2.Cost;
        }
        internal static bool CompareName(Item i1, Item i2)
        {
            if(i1.Name.CompareTo(i2.Name)== 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal static bool CompareVehicleType(Item i1, Item i2)
        {
            return i1.itemType < i2.itemType;
        }
    }
}