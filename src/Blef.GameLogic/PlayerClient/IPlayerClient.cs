namespace Blef.GameLogic.PlayerClient
{
    public interface IPlayerClient
    {
        void AddPlayers(Player[] players, int[] cardsCountPerPlayer);

        void AddPlayerBet(PlayerBet playerBet);

        PlayerDecision GetDecision();
    }
}