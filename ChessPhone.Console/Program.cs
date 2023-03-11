using System.Text.Json;
using ChessPhone.Core.Repositories;
using ChessPhone.Core.Services;

// for simple visualization


var service = new ChessPieceService();
var results = DataProvider.ChessPieces
    .Select(x => x.Name + ":" + service.CalculateNumberOfCombinations(x, DataProvider.Board, 7));

Console.WriteLine(JsonSerializer.Serialize(results));
Console.ReadKey();