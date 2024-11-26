using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    /*You have a list of Article objects, each with ArticleID, Title, and DatePublished. 
      Write a LINQ query to implement pagination, returning only the first 10 articles (using Skip and Take).*/

    class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }

        public DateTime DatePublished { get; set; }
    }
    internal class ElevenQuestion
    {
        List<Article> articles= new List<Article>()
        {
            new Article(){ ArticleId=1, Title="Title 1", DatePublished=new DateTime(2021,09,21) },
        new Article(){ ArticleId=2, Title="Title 2", DatePublished=new DateTime(2022,12,12) },
        new Article(){ ArticleId=3, Title="Title 3", DatePublished=new DateTime(2020,02,22) }
        };
        
        public void Execution()
        {
           var ans= articles.OrderBy(x => x.DatePublished).Take(2);
            foreach (var article in ans)
            {
                Console.WriteLine($"ArticleId : {article.ArticleId}, DatePublished : {article.DatePublished}");
            }
        }
    }
}
