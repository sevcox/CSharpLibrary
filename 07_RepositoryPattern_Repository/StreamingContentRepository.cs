using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        //Fake Database                           //used _ because that is naming convention
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //CRUD
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content); //functionality
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }

        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower()) //.ToLower because case sensitive 
                {
                    return content;
                }
            }
                return null; //not the best practice
        }

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle); //don't have to do repo. because we are living in the same space
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }

        //Get by other parameters
        //Get By Rating
    public List<StreamingContent> GetContentByRating (int starRating)
        {
            List<StreamingContent> contentByRating = new List<StreamingContent>();
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.StarRating == starRating)
                {
                    contentByRating.Add(content);
                }
                return contentByRating;
            }
            return null;
        }

        //Get by Family Friendly

        public List<StreamingContent> GetContentByIsFamilyFriendly (bool isFamilyFriendly)
        {
            List<StreamingContent> sortedList = new List<StreamingContent>();
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.IsFamilyFriendly == isFamilyFriendly)
                {
                    sortedList.Add(content);
                }
            }
            return sortedList;
        }
  
    }
}
