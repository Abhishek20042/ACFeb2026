namespace DemoApp.Services.Shopping;

public interface IDataAccessLayer
{
    ItemInfo ReadItemInfo(string name);
}