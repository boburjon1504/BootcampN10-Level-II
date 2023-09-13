public interface IMedicineService
{
    Medicine Create(int id, string name, string price, string expirationDate);
    List<Medicine> Get();
}
