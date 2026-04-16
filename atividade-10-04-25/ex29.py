alfabeto = []
letra = "abcdefghijklmnopqrstuvwxyz"
for i in letra:
    alfabeto.append(i)

nomes = []
for i in range(0, 5):
    nomes.append(input("nomes\n"))

ordenado = []
for i in range(0, 26):
    ordenado.append(" ")

for i in range(0, 5):
    for j in range(0, 26):
        if nomes[i][0] == alfabeto[j]:
            
            ordenado[j] = nomes[i]

j = 0
for i in range(0, 26):
    if ordenado[i] != " ":
        nomes[j] = ordenado[i]
        j+=1

print(nomes)
