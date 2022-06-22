namespace DonateApi.Repos
{
    public interface IDonationRepository
    {
        void AddDonationCount();
        int GetTotalDonationCount();
    }
}