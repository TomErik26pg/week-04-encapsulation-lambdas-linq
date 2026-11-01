DroneVault vault = new DroneVault();
vault.Add(new Drone("Delta"));
vault.Add(new Drone("Echo"));

List<Drone> copy = vault.GetDrones();

//1. Vis at `copy.RemoveAt(0)` ikke endrer vaultens antall når listen returneres som kopi.
Console.WriteLine($"Vault count before RemoveAt: {vault.Count}");
copy.RemoveAt(0);
Console.WriteLine($"Vault count after RemoveAt: {vault.Count}");

//refresh
copy.Clear();
copy = vault.GetDrones();

//2. Vis at endring av `copy[0].Name` likevel endrer objektet vaulten ser.
Console.WriteLine($"copy[0].Name before removal; {copy[0].Name}");
copy[0].Name = "Changed";
Console.WriteLine($"copy[0].Name after removal; {copy[0].Name}");

Console.WriteLine("Drones inside vault:");
vault.PrintAll();
