namespace Biblioteka
{
    public interface ISocket //interfejs do nawiązywania połączenia
    {
        ModelInfo Receive();
 
        void Send(ModelInfo model);
    }
}