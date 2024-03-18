using System;
using Microsoft.AnalysisServices.Tabular;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentPort = "51961";

            AdomdConnection adomdConnection = new AdomdConnection($"Data Source=localhost:{currenPort}");

            // Connect to Power Bi Desktop using TOM

            Server server = new Server();
            server.Connect($"localhost:{currentPort}");
            Model model = server.Database[0].Model;
            Table salesTable = model.Tables["Query1"]

            // Define Query (as a Command)
            // The AdomdCommant uses the above connection
            // Substitute this for your own query

            String query = System.IO.File.ReadAllText("QueryColours.dax");
            AdomdCommand adomdCommand = new AdomdCommand(query, adomdConnection);

            // Now need to run the Query