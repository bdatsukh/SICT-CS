import random as rd
import numpy as np
import matplotlib.pyplot as plt

W = [0.9, 0.4]
c1 = 2
c2 = 2
bound = [-10, 10]
d = 3

n_iterations = 50
n_particles = 6
target_error = 1e-6

class Particle():
    def __init__(self, d, bound):
        self.bound = bound
        self.position = min(bound) + np.random.rand(d) * (max(bound) - min(bound))
        self.pBest_position = self.position
        self.pBest_value = float('inf')
        self.velocity = np.array([0]*d)

    def update(self):
        self.position = self.position + self.velocity
        self.position = np.clip(self.position, min(self.bound), max(self.bound))

class Space():
    def __init__(self, n_particles, bound, k=2):
        self.n_particles = n_particles
        self.bound = bound
        self.particles = []
        self.gBest_value = float('inf')
        self.gBest_position = min(bound) + np.random.rand(d) * (max(bound) - min(bound))
        self.k = 2
        self.vmax = self.k*(max(self.bound) - min(self.bound)) / 2


    def fitness(self, particle):
        x = particle.position[0]
        y = particle.position[1]
        z = particle.position[2]
        f = 2*x**2 + 3*y**3 -4*z**2 
        return f

    def set_pBest(self):
        for particle in self.particles:
            fitness_candidate = self.fitness(particle)
            if (particle.pBest_value > fitness_candidate):
                particle.pBest_value = fitness_candidate
                particle.pBest_position = particle.position

    def set_gBest(self):
        for particle in self.particles:
            best_fitness_candidate = self.fitness(particle)
            if (self.gBest_value > best_fitness_candidate):
                self.gBest_value = best_fitness_candidate
                self.gBest_position = particle.position

    def update_particles(self, w):
        for particle in self.particles:
            inertial = w * particle.velocity
            self_confidence = c1 * rd.random() * (particle.pBest_position - particle.position)
            swarm_confidence = c2 * rd.random() * (self.gBest_position - particle.position)
            new_velocity = inertial + self_confidence + swarm_confidence
            particle.velocity = np.clip(new_velocity, -self.vmax, self.vmax)
            particle.update()

    def show_particles(self, iteration):
        
        print(iteration, 'iterations')
        print('BestPosition in this time:', self.gBest_position)
        print('BestValue in this time:', self.gBest_value)
        plt.gcf().clear()
        for particle in self.particles:
            plt.plot(particle.position[0], particle.position[1], particle.position[2], 'ro')
        plt.plot(self.gBest_position[0], self.gBest_position[1], self.gBest_position[2], 'bo')
        plt.title('PSO Simulation by team 3')
        plt.ylabel('objective function = | 2*x^2+3*y^3-4*z^2 |')
        plt.text(450, 1300, "Total particles     : "+str(n_particles))
        plt.text(-80, 1300, "Number of iterations: " + str(iteration))
        plt.text(-80, 1250, "Global minima : " + str(self.gBest_value))
        plt.pause(0.2)

  
search_space = Space(n_particles, bound)
particle_vector = [Particle(d, bound) for _ in range(search_space.n_particles)]
search_space.particles = particle_vector

w = np.linspace(min(W), max(W), n_iterations)

iteration = 0
plt.show()


while (iteration < n_iterations):
    search_space.set_pBest()
    search_space.set_gBest()

    search_space.show_particles(iteration)

    if (abs(search_space.gBest_value - 1) <= target_error):
        break

    search_space.update_particles(w[-(iteration + 1)])
    iteration += 1

print("The best solution is: ", search_space.gBest_position, " in ", iteration, " iterations")