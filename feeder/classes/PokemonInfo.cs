using System;
namespace PSSniper
{
    /// <summary>
    /// Executing the "dotnet run command in the application folder will run this app.
    /// </summary>
    public class PokemonInfo 
    {
        public string PokemonName;
        public double Latitude;
        public double Longtitude;
        public double IV;
        public ulong EncounterId;
        public string SpawnpointId;
        public Int64 expiration; 

        public DateTime expirationdt; 

        public PokemonInfo () {

        }

   }
}