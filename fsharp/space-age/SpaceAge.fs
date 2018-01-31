module SpaceAge
    type Planet = Earth | Mercury | Venus | Mars | Jupiter| Saturn | Uranus| Neptune  
    let earthSeconds = 31557600m;
    let days = dict[Planet.Earth, 1.0m; Planet.Mercury, 0.2408467m; Planet.Venus, 0.61519726m; Planet.Mars, 1.8808158m; Planet.Jupiter, 11.862615m; Planet.Saturn, 29.447498m; Planet.Uranus, 84.016846m; Planet.Neptune, 164.79132m]
    let spaceAge (planet: Planet) (seconds: decimal): decimal = 
        System.Math.Round(seconds / earthSeconds / days.Item(planet), 2)