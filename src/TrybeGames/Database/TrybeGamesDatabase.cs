namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    // 4. Crie a funcionalidade de buscar jogos desenvolvidos por um estúdio de jogos
    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        // implementar
        var gamesPerStudio = (
            from game in Games
            where game.DeveloperStudio == gameStudio.Id
            select game
        );

        return gamesPerStudio.ToList();
    }

    // 5. Crie a funcionalidade de buscar jogos jogados por uma pessoa jogadora
    public List<Game> GetGamesPlayedBy(Player player)
    {
        // Implementar
        var gamesPerPlayer = (
            from game in Games
            from playerSelected in game.Players
            where playerSelected == player.Id
            select game
        );

        return gamesPerPlayer.ToList();
    }

    // 6. Crie a funcionalidade de buscar jogos comprados por uma pessoa jogadora
    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        // Implementar
        var gamesOwnedByPlayer = (
            from game in Games
            from playerSelected in playerEntry.GamesOwned
            where playerSelected == game.Id
            select game
        );

        return gamesOwnedByPlayer.ToList();

    }


    // 7. Crie a funcionalidade de buscar todos os jogos junto do nome do estúdio desenvolvedor
    public List<GameWithStudio> GetGamesWithStudio()
    {
        // Implementar
        var gameWithStudio = (
            from game in Games
            join studio in GameStudios
            on game.DeveloperStudio equals studio.Id
            select new GameWithStudio
            {
                GameName = game.Name,
                StudioName = studio.Name,
                NumberOfPlayers = game.Players.Count
            }
        );

        return gameWithStudio.ToList();
    }

    // 8. Crie a funcionalidade de buscar todos os diferentes Tipos de jogos dentre os jogos cadastrados
    public List<GameType> GetGameTypes()
    {
        // Implementar
        var gameTypes = (
            from game in Games
            select game.GameType
        );

        return gameTypes.Distinct().ToList();
    }

    // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
    public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
    {
        // Implementar
        throw new NotImplementedException();
    }

}
