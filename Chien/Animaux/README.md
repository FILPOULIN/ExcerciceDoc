<a name='assembly'></a>
# Animaux

## Contents

- [Chien](#T-Animaux-Chien 'Animaux.Chien')
  - [#ctor(nom,age,race)](#M-Animaux-Chien-#ctor-System-String,System-Int32,System-String- 'Animaux.Chien.#ctor(System.String,System.Int32,System.String)')
  - [Aboyer()](#M-Animaux-Chien-Aboyer 'Animaux.Chien.Aboyer')
  - [CalculerAge(vraiAge,trancheAge)](#M-Animaux-Chien-CalculerAge-System-Int32,System-String- 'Animaux.Chien.CalculerAge(System.Int32,System.String)')

<a name='T-Animaux-Chien'></a>
## Chien `type`

##### Namespace

Animaux

##### Summary

Cette classe est utilisée pour initialisé un ou plusieurs chien(s)

```
Chien maClasse = new Chien();
maClasse.CalculerAge(vraiAge,trancheAge)
```

```
Chien maClasse = new Chien();
maClasse.Aboyer()
```

<a name='M-Animaux-Chien-#ctor-System-String,System-Int32,System-String-'></a>
### #ctor(nom,age,race) `constructor`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| nom | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | C'est le nom du chien |
| age | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | L'âge du chien |
| race | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | La race du chien |

<a name='M-Animaux-Chien-Aboyer'></a>
### Aboyer() `method`

##### Summary

Cette fonction est simplement présente pour donner l'aboiement du chien.

##### Returns

Cette retourne une string décrivant comment aboit le chien

##### Parameters

This method has no parameters.

<a name='M-Animaux-Chien-CalculerAge-System-Int32,System-String-'></a>
### CalculerAge(vraiAge,trancheAge) `method`

##### Summary

Cette fonction est simplement présente pour donner dans quelle tranche d'âge se situe le chien.

##### Returns

Cette fonction retourne la tranche d'âge

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vraiAge | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | L'âge du chien |
| trancheAge | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | La tranche d'âge du chien |
