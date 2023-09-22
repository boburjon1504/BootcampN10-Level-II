/*
 * User model ( id, firstName, lastName, isActive )

UserService ( Users )
EmployeeService 

- CreatePerformanceRecordAsync ( id ) - berilgan userni fullnami bilan fayl yaratsin

PerformanceService

- ReportPerformanceAsync ( id ) - berilgan userni fullname bilan yaratilgan faylni ochib, ichiga "All good :)" deb yozsin

AccountService 
- CreateReportAsync ( id ) - berilgan user uchun report fayl yaratib, ichini to'ldirish uchun tepadagi service lardan foydalansin

- bunda 2 ta service bir paytda faylga access qilishi mumkinligi uchun mutex dan foydalaning
- lekin AccountSerivce.CreateReportAsync ichida serivce lar ishini tezlashtirish uchun task continuation dan foydalaning
 */
using N43_HT_1.Models;
using N43_HT_1.Services;


var userService = new UserService();
var userA = userService.Create(new User("Jogn", "Wick"));
var userB = userService.Create(new User("Jogn", "Wick"));
var userC = userService.Create(new User("Jogn", "Wick"));
var accountService = new AccountService(userService);
await accountService.CreateReportAsync(userA.Id);