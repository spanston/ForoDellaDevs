using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForoDellaDevs.Models.Forum
{

    //This model is passed down to the view
    //Wraps ForumListingModel
    //Good practice 
    //This is done in order order to expand with more data to display
    public class ForumIndexModel
    {
        public IEnumerable<ForumListingModel> ForumList { get; set; }
    }
}
