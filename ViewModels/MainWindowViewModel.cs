using System;
using System.Collections.Generic;
using _4_4.Models;
namespace _4_4.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {

        Blogs = new List<Blog>()
        {
            new Blog()
            {
                Article = "Blog 1",
                Text = "«Пиковый Денис и пиковый Леван? Без шансов, Сагинашвили выше уровнем!» — Мы посмотрели подкаст Девона Ларратта и Кирилла Сарычева! И вот выжимка из слов канадца: 1. «Не делайте жим лёжа для прогресса в армрестлинге. 2. Спаррингуйте только с более слабыми соперниками. 3. Нужно держать баланс между силой и здоровьем. 4. Следите за кровообращением с соединительных тканях. 5. Я сделал 3 укола стволовых клеток в руки, и полностью вылечился.",
                ImagePath = "DevonLarrat.jpg",
                Tags = "#DevonLarrat  #Sarichev #Armwrestling"
            },

            new Blog()
            {
                Article = "Blog 2",
                Text = "Честно говоря я испытал шок! Более некомпетентного результата в истории Российского бодибилдинга еще не было. Единственного человека который соответствует критериям Про-атлета ставят на 4-е место - Андрей Прокофьев не скрывает своих эмоций после объявления победителей на Siberian Power Show",
                Tags = "#Siberian Power Show"
            },

        };
        News = new List<New>
        {
            new() { Text = "Армфайт Дениса Цыпленкова и Ермема Гаспарини отменен, из-за проблем со здоровьем Дениса.", PublishTime = DateTime.Now },
            new() { Text = "На East vs West победил Леван Сагинашвили, чего многие не ожидали", PublishTime = DateTime.Now.AddDays(-1) }
        };
    }

    public List<Blog> Blogs { get; set; }
    public List<New> News { get; set; }


}