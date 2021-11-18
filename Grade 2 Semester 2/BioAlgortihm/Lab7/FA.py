import numpy as np

def FA(fun, dim, bound, N=5, alpha=1, beta=1, gamma=0.01, theta=0.97, it=1000):
    pop = np.random.rand(N, dim)
    scale = np.abs(np.max(bound) - np.min(bound))
    pop = np.min(bound) + pop * scale
    fitness = [fun(x) for x in pop]

    for t in range(it):
        for i in range(N):
            for j in range(N):
                if i != j and fitness[i] > fitness[j]:
                    r = np.sqrt(np.sum((pop[i] - pop[j])**2))
                    b = beta*np.e**(-gamma * r) * (pop[j] - pop[i])
                    a = (alpha * theta) * (np.random.rand() - 0.5) * scale
                    newX = np.clip(pop[i] + b + a, np.min(bound), np.max(bound))
                    newFitness = fun(newX)
                    if newFitness < fitness[i]:
                        pop[i] = newX
                        fitness[i] = newFitness
                    
    return np.append(pop[np.argmin(fitness)], np.min(fitness))

def funct(x):
    return x[0]**2 - x[0]*x[1] + x[1]**2 + 2*x[0] + 4*x[1] + 3

print("[x0, x1, min]: ", FA(funct, 2, (-5, 5)))