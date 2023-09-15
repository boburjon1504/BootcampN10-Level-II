using System.Collections;

namespace N38_HT_1.Models;

public class UsersContainer:IEnumerable
{
    /*
     * consturctor - default constructor bo'lsin
- constructor - userlar kolleksiyasini qabul qiladigan bo'lsin ( array, list yoki nima IEnumerable bo'lsa ham )
- indexer - id bo'yicha bitta value qaytaradigan
- indexer - keyword bo'ycha bitta value qaytaradigan
- indexer - index bo'yicha bitta value qaytaradigan ( array ga o'xshab )
- unda IEnumerable interfeysini implement qiling
- va userlarni saqlash uchun biror kolleksiya
*/
    private readonly List<User> _users;
    public UsersContainer() { }
    public UsersContainer(List<User> users)=>_users = users;
    public User this[Guid id]=>_users.Find(user=>user.Id==id);
    public User? this[string key]=>_users
        .FirstOrDefault(user=>user.FirstName.Contains(key,StringComparison.OrdinalIgnoreCase)
        || user.LastName.Contains(key,StringComparison.OrdinalIgnoreCase)
        || user.EmailAddress.Contains(key, StringComparison.OrdinalIgnoreCase));
    public User this[int index] => _users[index];

    public IEnumerator GetEnumerator()
    {
        return _users.GetEnumerator();
    }
}