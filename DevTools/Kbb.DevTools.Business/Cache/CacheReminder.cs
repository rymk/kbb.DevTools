namespace Kbb.DevTools.Business.Cache
{
    public class CacheReminder
    {
        // TODO: create a reusable, scalable pattern for caching...
        //   - should there be a DB cache layer that sits at the DAL/Repo layer between AppService interaction with the DB? 
        //      - I could see value in this for 
        //   - should there (also) be an application layer where we could convert DB types to DTOs, store the DTOs in memory and then read from the cache to speed things up?
        
        // EXAMPLE to consider: The list of statuses that will be stored in dbo.Status...
        //  Or getting UserFullnames... this would be easy enough to update the cache when new customer joins... in theory.
        //  i remember reading about a DB cache layer that was automatically updated everytime the DB storage records changed.
        //     cant remember if this was an MS SQL feature or what...

        // is there any reason i should use redis? cant think of a reason over using application cache,
        // but if i'm wrong and want to switch cache storage layer, the architecture allow that to be a seamless conversion..

        // the caches should be able to be cleared one-at-a-time or all.
        //  prob repopulates at time of clearing...
    }
}
