
using Prototype.RealExample;

Zombie zombie = new Zombie { Id = 1, Name = "Zombie 1", Health = 100 };
Vampire vampire = new Vampire { Id = 2, Name = "Vampire 1", Bloodlust = 50 };
Mummy mummy = new Mummy { Id = 3, Name = "Mummy", Bandage = 25 };

zombie.Attack();
vampire.Attack();
mummy.Attack();

Zombie clonedZombie = (Zombie)zombie.Clone();
Vampire clonedVampire = (Vampire)vampire.Clone();
Mummy clonedMummy = (Mummy)mummy.Clone();


clonedZombie.Id = 4;
clonedZombie.Name = "Zombie 2";
clonedZombie.Health = 120;
clonedZombie.Attack();

zombie.Attack();

clonedVampire.Id = 4;
clonedVampire.Name = "Vampire 2";
clonedVampire.Bloodlust = 70;
clonedVampire.Attack();

vampire.Attack();

clonedMummy.Id = 4;
clonedMummy.Name = "Mummy 2";
clonedMummy.Bandage = 17;
clonedMummy.Attack();

mummy.Attack();