/*
Sam Blastoise Water 18
Narry Pikachu Electricity 22
John Kadabra Psychic 90
Tournament
Fire
Electricity
Fire
End
 */

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = GetTrainerInfo();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                switch (command)
                {
                    case "Fire":
                        foreach (Trainer trainer in trainers.Values)
                        {
                            bool doesItHavePokemonWithFireElement = false; 

                            foreach (var pokemon in trainer.Pokemons)
                            {
                                if (pokemon.Element == "Fire")
                                {
                                    doesItHavePokemonWithFireElement = true;
                                    break;
                                }
                            }

                            if (doesItHavePokemonWithFireElement)
                            {
                                trainer.Badges++;
                            }
                            else
                            {
                                for (int n = 0; n < trainer.Pokemons.Count; n++)
                                {
                                    trainers[trainer.Name].Pokemons[n].Health -= 10;

                                    if (trainers[trainer.Name].Pokemons[n].Health <= 0)
                                    {
                                        trainers[trainer.Name].Pokemons.Remove(trainers[trainer.Name].Pokemons[n]);
                                    }
                                }
                            }
                        } 
                        break;
                    case "Water":
                        foreach (Trainer trainer in trainers.Values)
                        {
                            bool doesItHavePokemonWithWaterElement = false;

                            foreach (var pokemon in trainer.Pokemons)
                            {
                                if (pokemon.Element == "Water")
                                {
                                    doesItHavePokemonWithWaterElement = true;
                                    break;
                                }
                            }

                            if (doesItHavePokemonWithWaterElement)
                            {
                                trainer.Badges++;
                            }
                            else
                            {
                                for (int n = 0; n < trainer.Pokemons.Count; n++)
                                {
                                    trainers[trainer.Name].Pokemons[n].Health -= 10;

                                    if (trainers[trainer.Name].Pokemons[n].Health <= 0)
                                    {
                                        trainers[trainer.Name].Pokemons.Remove(trainers[trainer.Name].Pokemons[n]);
                                    }
                                }
                            }
                        }
                        break;
                    case "Electricity":
                        foreach (Trainer trainer in trainers.Values)
                        {
                            bool doesItHavePokemonWithElectricityElement = false;

                            foreach (var pokemon in trainer.Pokemons)
                            {
                                if (pokemon.Element == "Electricity")
                                {
                                    doesItHavePokemonWithElectricityElement = true;
                                    break;
                                }
                            }

                            if (doesItHavePokemonWithElectricityElement)
                            {
                                trainer.Badges++;
                            }
                            else
                            {
                                for (int n = 0; n < trainer.Pokemons.Count; n++)
                                {
                                    trainers[trainer.Name].Pokemons[n].Health -= 10;

                                    if (trainers[trainer.Name].Pokemons[n].Health <= 0)
                                    {
                                        trainers[trainer.Name].Pokemons.Remove(trainers[trainer.Name].Pokemons[n]);
                                    }
                                }
                            }
                        }
                        break;
                }
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.Value.Badges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }

        //static void CheckIfTrainersHaveFireElementPokemon()
        //{
        //    foreach ()
        //}

        //static void CheckIfTrainersHaveWaterElementPokemon()
        //{

        //}

        //static void CheckIfTrainersHaveElectricityElementPokemon()
        //{

        //}

        static Dictionary<string, Trainer> GetTrainerInfo()
        {
            var trainers = new Dictionary<string, Trainer>();

            string command;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] trainerInfo = command
                    .Split(' ');

                string trainerName = trainerInfo[0];
                string pokemonName = trainerInfo[1];
                string pokemonElement = trainerInfo[2];
                int pokemonHealth = int.Parse(trainerInfo[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = new Trainer(trainerName, 0);

                if (!trainers.ContainsKey(trainer.Name))
                {
                    trainers.Add(trainer.Name, trainer);
                }

                trainers[trainer.Name].Pokemons.Add(pokemon);
            }

            return trainers;
        }
    }
}