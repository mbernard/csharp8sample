using System.Collections.Generic;
using System.Data.SqlClient;

namespace Samples.AsyncStreams
{
    public static class Producer
    {
        public static async IAsyncEnumerable<string> GetAllNames()
        {
            var pageIndex = 0;
            const int pageSize = 100;
            var hasMore = false;
            do
            {
                // ****IMPORTANT ****
                // Never EVER do this in a real application. The following block of code is
                // not secure and could be subject to an attack known as SQL Injection.
                await using var conn = new SqlConnection("ConnectionString here");
                await using var cmd = new SqlCommand(
                    @$"
                    SELECT Name 
                    FROM Users
                    ORDER BY Name
                    OFFSET {pageIndex * pageSize} ROWS
                    FETCH NEXT {pageSize} ROWS ONLY",
                    conn);
                await using var reader = await cmd.ExecuteReaderAsync();
                while (reader.Read())
                {
                    yield return reader.GetString(0); // This is the name column
                }

                pageIndex++;
                hasMore = reader.HasRows;
            } while (hasMore);
        }
    }
}