namespace DemoApp.Models;

public interface IDataAccessLayer
{
    ItemInfo FetchItemInfo(string id);
}