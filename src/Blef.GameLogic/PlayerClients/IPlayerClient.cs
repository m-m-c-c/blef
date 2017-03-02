namespace Blef.GameLogic.PlayerClients
{
    public interface IPlayerClient
    {
        PlayerMove GetMove(GameHistoryForClient gameHistory);
    }
}