/*
 * buyurtmalar ( Order ) va bitta order ichidagi sotib
 * olingan tovarlar ( Product ) uchun endpoint qanday bo'lishligi kerak ?
  web api konfiguratsiyasi uchun yaratilgan fayllar qaysi layerda turishligi kerak ?
  controller ichida nechta service inject qilish mumkin ?
  controller ichida foundations service larini ishlatish mumkinmi ?
 */


/*
 *  1 - javob
 * barcha buyurtmalarni olish uchun bitta [HttpGet] va Get() , 
 * bir buyurma bo'lgan tovarni olish uchun [HttpGet("{orderId:(Type)}"] bo'lishi kerak
 */


/*2- javob
 * Configuration filelar asosan Api ni o'zida saqlanadi
 */

/*3- javob
 * 
 * controller ichiga cheksiz ko'p servicelarni registratsiya qilsa bo'ladi
 */

/*4- javob
 * 
 * Orchestretion servicelar orqali ishlatish maqsadga muvofiq bo'ladi
 * 
 */