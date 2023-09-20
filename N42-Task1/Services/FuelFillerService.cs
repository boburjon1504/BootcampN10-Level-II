﻿
using N42_Task1.Models;
using System.Text;

namespace N42_Task1.Services;
public class FuelFillerService
{
    private static readonly int FuelLiterPrice = 6;

    public int Fill(Car car)
    {
        var list = new List<StringBuilder>();
        for (var index = 0; index < 100_000_000; index++)
        {
            list.Add(new StringBuilder(
                "Lorem ipsum dolor sit " +
                "amet consectetur adipisicing elit." +
                " Odit perspiciatis, dolore excepturi " +
                "nulla minima est tempora dignissimos. " +
                "Voluptatum voluptate enim id error, odit, " +
                "minus unde debitis quod possimus eveniet " +
                "ad odio obcaecati ut nihil fugiat sed maiores" +
                " voluptates eos praesentium explicabo, ex placeat " +
                "hic autem! Voluptatibus minima dolor nostrum " +
                "delectus! Repudiandae impedit quibusdam nisi " +
                "facilis molestias quod, harum ipsa non " +
                "temporibus, minus fugiat! Quasi quaerat " +
                "cupiditate doloribus soluta nam consectetur " +
                "nulla quae illum mollitia iure. Optio iusto " +
                "est soluta veritatis, adipisci odit eos, vero" +
                " corrupti, mollitia enim neque beatae quia " +
                "natus voluptatum ea at accusamus et laudantium " +
                "ratione reprehenderit perspiciatis in. Nobis, " +
                "alias porro, tempore distinctio reiciendis " +
                "necessitatibus similique dignissimos" +
                " perspiciatis ratione cupiditate officiis" +
                " esse libero explicabo assumenda nisi quae " +
                "fugiat ullam quos ea nihil iste totam " +
                "dolorem eveniet? Error quae similique " +
                "voluptates, tempora cumque rem rerum " +
                "labore est quod eos aperiam a corporis " +
                "ratione excepturi fugiat ut. A aliquam " +
                "alias, omnis soluta enim maxime maiores? " +
                "Ad nisi labore quas in earum similique, " +
                "soluta excepturi minus voluptates aut ab natus minima " +
                "deserunt. Numquam nobis non ad voluptatem quibusdam! Iure," +
                " magnam adipisci doloremque sequi quae maxime omnis " +
                "repellat itaque beatae saepe qui eum blanditiis illo " +
                "dolore animi asperiores accusantium nisi suscipit odit" +
                " distinctio reprehenderit laboriosam nostrum in. Provident, " +
                "ut totam voluptas maiores earum in sit! Soluta, reprehenderit " +
                "saepe ad iure quo nihil omnis expedita id quia voluptate temporibus" +
                " dicta. Molestias, nostrum eos! Maiores quo nihil sit voluptatem " +
                "perferendis omnis natus eum ab velit iusto provident aliquid adipisci" +
                " libero iste doloribus, obcaecati veritatis eaque nostrum animi " +
                "accusamus earum sunt? Sit et expedita culpa maiores asperiores " +
                "autem id debitis repellat deserunt numquam iure officia eligendi " +
                "harum ipsum dolore, similique omnis, fuga tempore. Quam possimus " +
                "quasi nobis odit nostrum eaque voluptate quae quis doloribus placeat! " +
                "Id ratione et dolores earum nam ex delectus voluptas incidunt " +
                "beatae, quia fugit qui mollitia ut dolore officia quasi voluptatum," +
                " voluptate omnis? Officia aliquid libero temporibus explicabo dolores " +
                "quas labore fugiat natus odio quam? Dolorum molestias eos, " +
                "animi sequi maiores excepturi fugiat sed eveniet sint pariatur, " +
                "blanditiis asperiores incidunt, commodi provident! Adipisci, " +
                "exercitationem praesentium voluptatem reiciendis tempora debitis, " +
                "officia cumque itaque ex inventore id? Recusandae deserunt nobis, " +
                "sequi provident ipsa modi vero fuga voluptates nemo! Ad omnis harum quod," +
                " possimus rerum facilis aliquid voluptate repudiandae sit aliquam " +
                "nobis ex deserunt deleniti doloremque consequuntur maxime ducimus " +
                "nesciunt debitis. Dignissimos at, eaque magni rem error modi ea maiores " +
                "velit tenetur. Quos quod libero eum ad inventore quidem repellendus" +
                " eaque, dolores dolore suscipit eos, quas debitis enim similique nequ" +
                "e praesentium tenetur repudiandae dicta corporis voluptatem sunt earum " +
                "magni minus iste. Laudantium pariatur perspiciatis cumque, tenetur" +
                " voluptas minus accusantium rem sed. Temporibus, consectetur saepe" +
                " nostrum, corporis provident libero dolore architecto dolor ullam " +
                "inventore magnam similique, quam eum alias nisi quibusdam maiores " +
                "repudiandae minima unde pariatur numquam. Eos ex quam molestias" +
                " saepe placeat, asperiores reprehenderit expedita iusto necessitatibus " +
                "voluptatum possimus veniam voluptatibus labore tempore totam omnis quod " +
                "aperiam, quos, iure porro ea corporis animi! Obcaecati, nulla quam quisquam " +
                "in voluptatibus optio quod dolores! Eligendi laudantium, repellat" +
                " dicta inventore neque enim beatae commodi tenetur, nemo modi ad " +
                "blanditiis ipsa. Debitis numquam labore ipsa nostrum quisquam culpa " +
                "natus, quae, aliquam nisi corporis voluptatibus libero quasi necessitatibus" +
                " praesentium dolore aspernatur! Porro dolorum consequuntur necessitatibus " +
                "eligendi soluta magnam qui voluptate exercitationem, doloribus, nam nulla " +
                "consequatur incidunt earum fuga quibusdam natus eveniet tempora aut aperiam. " +
                "Nemo impedit ratione natus, corporis ut unde aspernatur inventore ullam, " +
                "labore porro rem saepe dolor iusto dolorem enim veniam necessitatibus sunt " +
                "vitae deleniti nihil repellendus nisi. Placeat nesciunt quisquam est " +
                "iusto? Iure unde eius dolor dicta est dolorum provident. Quis eum ad " +
                "distinctio ut, dolores suscipit corrupti nam eveniet illo eos eligendi " +
                "quia numquam reiciendis? Fuga adipisci optio praesentium, corporis ea " +
                "necessitatibus voluptatibus incidunt earum beatae nesciunt accusamus " +
                "placeat nulla. Iusto id, rem repellat minus sed amet perspiciatis! Aliquam, i" +
                "psum commodi quam rem explicabo id incidunt facilis. Quaerat vitae aut " +
                "doloribus voluptatem dolore, necessitatibus fugit nobis ex ea perspiciatis " +
                "laudantium libero officia eius suscipit consequatur illum quasi. Architecto" +
                " cumque, expedita, maiores esse magni ab dignissimos minus maxime, eveniet " +
                "nesciunt culpa omnis sequi! Officia unde sit quae. Veniam neque, iusto amet " +
                "veritatis architecto pariatur mollitia atque culpa fuga quidem molestiae " +
                "quos debitis velit exercitationem distinctio? Blanditiis, unde. Ipsam " +
                "suscipit eum voluptatem debitis quasi, ducimus eveniet illo cupiditate " +
                "cum porro dolorum tenetur libero dicta reiciendis, deleniti et ex! Quis " +
                "nobis ut, nemo voluptas consectetur, porro repellat illum dolores est" +
                " sunt sequi cumque vero soluta error aut ipsum sed dolorem maiores hic" +
                " id optio, ullam alias repudiandae! Rerum dolores ab excepturi nulla " +
                "consequuntur obcaecati quis ipsam dolorum eligendi. Laudantium sit" +
                " quam tenetur molestias neque, dolorum hic assumenda cum, nostrum sed " +
                "porro eveniet illum, recusandae quidem nisi. Incidunt hic eaque porro nam " +
                "temporibus! Ipsa possimus iure tenetur quisquam suscipit itaque dolores " +
                "aperiam, perferendis ipsum at neque soluta? Porro expedita, hic aliquid " +
                "eaque esse harum quidem eius facere non dolore eos nobis earum fugit quis," +
                " provident veritatis nihil labore nulla tempora suscipit velit et. " +
                "Voluptatem saepe ab quaerat sunt provident quod, animi pariatur fuga, nesciunt in possimus, perspiciatis aperiam aut totam natus rerum sed voluptas sequi numquam delectus. Debitis neque modi sunt nulla ratione sequi consequuntur nisi, fuga aliquam, ut provident dicta et tempore adipisci magnam accusantium recusandae corrupti deserunt magni fugit enim? Dolorem minus accusantium quod eum esse culpa aperiam voluptatem quis inventore voluptatum a molestias expedita laudantium architecto mollitia tempora excepturi saepe iure, rerum modi veritatis commodi quos! Beatae quibusdam et alias in nisi incidunt pariatur, facilis eaque fugit dolore obcaecati vitae vero voluptatibus aperiam eos delectus! Quasi ipsum tempore, explicabo pariatur ut saepe adipisci. Veritatis eos molestiae mollitia cumque quam nemo illo, fugiat at obcaecati voluptates explicabo aliquid atque, sed illum, vitae numquam ducimus? Labore quaerat dolores quisquam placeat iusto modi sapiente, consequuntur corporis praesentium doloremque ratione dignissimos natus rerum ullam delectus, expedita repellendus et nisi. Amet, laboriosam veniam quis eveniet, tempore quasi beatae distinctio esse iusto delectus aliquid sequi ea sed ratione incidunt voluptatem dolore consectetur et quaerat fugiat totam sunt id. Dolore, ipsam dignissimos."));



        }
            var test = car.FuelLiters * FuelLiterPrice;
            return car.FuelLiters * FuelLiterPrice;
    }
}