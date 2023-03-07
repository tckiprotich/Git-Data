using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Git_Data.Models
{
    public class Repository
    {
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? git_url { get; set; }
    public string? pullRequests_Count { get; set; }
    public string? clone_url { get; set; }
    public string? forks_count { get; set; }
    public string? stargazers_count { get; set; }


    }
}