using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using RandomLiteratureTopicGenerator.Models;

namespace RandomLiteratureTopicGenerator.Controllers
{
    public class HomeController : Controller
    {
        List<Topic> topics;

        public HomeController(ILogger<HomeController> logger)
        {
            topics = new List<Topic>()
            {
                new Topic()
                {
                    Id = 1,
                    Name = "Железният светилник",
                    Genre = "Роман",
                    Author = "Димитър Талев",
                    Url = "https://domashno.bg/tvorba/zhelezniyat-svetilnik"
                },
                new Topic()
                {
                    Id = 2,
                    Name = "Бай Ганьо Журналист",
                    Genre = "Повест",
                    Author = "Алеко Константинов",
                    Url = "https://domashno.bg/tvorba/bay-gano"
                },
                new Topic()
                {
                    Id = 3,
                    Name = "Балкански синдром",
                    Genre = "Комедия",
                    Author = "Станислав Стратиев",
                    Url = "https://domashno.bg/tvorba/balkanski-sindrom"
                },
                new Topic()
                {
                    Id = 4,
                    Name = "Паисий",
                    Genre = "Ода",
                    Author = "Иван Вазов",
                    Url = "https://domashno.bg/tvorba/paisiy"
                },
                new Topic()
                {
                    Id = 5,
                    Name = "Новото гробище над Сливница",
                    Genre = "Елегия",
                    Author = "Иван Вазов",
                    Url = "https://domashno.bg/tvorba/novoto-grobishhe-nad-slivnica"
                },
                new Topic()
                {
                    Id = 6,
                    Name = "При Рилския манастир",
                    Genre = "Стихотворение",
                    Author = "Иван Вазов",
                    Url = "https://domashno.bg/tvorba/pri-rilskiya-manastir"
                },
                new Topic()
                {
                    Id = 7,
                    Name = "История",
                    Genre = "Стихотворение",
                    Author = "Никола Вапцаров",
                    Url = "https://domashno.bg/tvorba/istoriia"
                },
                new Topic()
                {
                    Id = 8,
                    Name = "Ноев Ковчег",
                    Genre = "Роман",
                    Author = "Йордан Радичков",
                    Url = "https://domashno.bg/tvorba/noev-kovceg"
                },
                new Topic()
                {
                    Id = 9,
                    Name = "Борба",
                    Genre = "Стихотворение",
                    Author = "Христо Ботев",
                    Url = "https://domashno.bg/tvorba/borba"
                },
                new Topic()
                {
                    Id = 10,
                    Name = "До моето първо либе",
                    Genre = "Стихотворение",
                    Author = "Христо Ботев",
                    Url = "https://domashno.bg/tvorba/do-moeto-prvo-libe"
                },
                new Topic()
                {
                    Id = 11,
                    Name = "Андрешко",
                    Genre = "Разказ",
                    Author = "Иван Вазов",
                    Url = "https://domashno.bg/tvorba/andreshko"
                },
                new Topic()
                {
                    Id = 12,
                    Name = "Приказка за стълбата",
                    Genre = "Фейлетон",
                    Author = "Христо Смирненски",
                    Url = "https://domashno.bg/tvorba/prikazka-za-stielbata"
                },
                new Topic()
                {
                    Id = 13,
                    Name = "Крадецът на праскови",
                    Genre = "Повест",
                    Author = "Емилиян Станев",
                    Url = "https://domashno.bg/tvorba/kradeciet-na-praskovi"
                },
                new Topic()
                {
                    Id = 14,
                    Name = "Градушка",
                    Genre = "Стихотворение",
                    Author = "Пейо Яворов",
                    Url = "https://domashno.bg/tvorba/gradushka"
                },
                new Topic()
                {
                    Id = 15,
                    Name = "Спи езерото",
                    Genre = "Лирическа миниатюра",
                    Author = "Пенчо Славейков",
                    Url = "https://domashno.bg/tvorba/spi-ezeroto"
                },
                new Topic()
                {
                    Id = 16,
                    Name = "Помниш ли, помниш ли...",
                    Genre = "Елегия",
                    Author = "Димчо Дебелянов",
                    Url = "https://domashno.bg/tvorba/pomnish-li-pomnish-li"
                },
                new Topic()
                {
                    Id = 17,
                    Name = "Аз искам да те помня все така...",
                    Genre = "Елегия",
                    Author = "Димчо Дебелянов",
                    Url = "https://domashno.bg/tvorba/az-iskam-da-te-pomnia-vse-taka"
                },
                new Topic()
                {
                    Id = 18,
                    Name = "Колко си хубава",
                    Genre = "Стихосбирка",
                    Author = "Христо Фотев",
                    Url = "https://domashno.bg/tvorba/kolko-si-xubava"
                },
                new Topic()
                {
                    Id = 19,
                    Name = "Посвещение",
                    Genre = "Стихотворение",
                    Author = "Петя Дубарова",
                    Url = "https://domashno.bg/tvorba/posveshhenie"
                },
                new Topic()
                {
                    Id = 20,
                    Name = "Спасова могила",
                    Genre = "Разказ",
                    Author = "Елин Пелин",
                    Url = "https://domashno.bg/tvorba/spasova-mogila"
                },
                new Topic()
                {
                    Id = 21,
                    Name = "Ветрената мелница",
                    Genre = "Разказ",
                    Author = "Елин Пелин",
                    Url = "https://domashno.bg/tvorba/vetrenata-melnica"
                },
                new Topic()
                {
                    Id = 22,
                    Name = "Молитва",
                    Genre = "Стихотворение",
                    Author = "Атанас Далчев",
                    Url = "https://domashno.bg/tvorba/molitva"
                },
                new Topic()
                {
                    Id = 23,
                    Name = "Вяра",
                    Genre = "Стихотворение",
                    Author = "Никола Вапцаров",
                    Url = "https://domashno.bg/tvorba/viara"
                },
                new Topic()
                {
                    Id = 24,
                    Name = "Песента на колелетата",
                    Genre = "Разказ",
                    Author = "Йордан Йовков",
                    Url = "https://domashno.bg/tvorba/pesenta-na-koleletata"
                },
                new Topic()
                {
                    Id = 25,
                    Name = "Балада за Георг Хених",
                    Genre = "Повест",
                    Author = "Виктор Пасков",
                    Url = "https://domashno.bg/tvorba/balada-za-georg-xenix"
                },
                new Topic()
                {
                    Id = 26,
                    Name = "Потомка",
                    Genre = "Стихотворение",
                    Author = "Елисавета Багряна",
                    Url = "https://domashno.bg/tvorba/potomka"
                },
                new Topic()
                {
                    Id = 27,
                    Name = "Две души",
                    Genre = "Стихотворение",
                    Author = "Пейо Яворов",
                    Url = "https://domashno.bg/tvorba/dve-dushi"
                },
                new Topic()
                {
                    Id = 28,
                    Name = "Честен кръст",
                    Genre = "Поема",
                    Author = "Борис Христов",
                    Url = "https://domashno.bg/tvorba/cesten-kriest"
                },
            };
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Generate()
        {
            Random random = new Random();

            int num = random.Next(1, topics.Count);

            var model = new Topic();

            model.Id = topics[num].Id;
            model.Name = topics[num].Name;
            model.Url = topics[num].Url;

            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
