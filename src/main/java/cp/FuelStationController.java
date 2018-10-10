package cp;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class FuelStationController {

    private final FuelStationRepository repository;

    FuelStationController(FuelStationRepository repository) {
        this.repository = repository;
    }

    @GetMapping("/api/fuelstations")
    public Iterable<FuelStation> all() {
        return repository.findAll();
    }

    @GetMapping("/api/fuelstations/{id}")
    FuelStation one(@PathVariable Long id) {

        return repository.findOne(id);
    }
}
