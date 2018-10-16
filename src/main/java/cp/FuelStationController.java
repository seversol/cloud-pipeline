package cp;

import org.springframework.data.domain.PageRequest;
import org.springframework.data.domain.Sort;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class FuelStationController {

  private final FuelStationRepository repository;

  FuelStationController(FuelStationRepository repository) {
    this.repository = repository;
  }

  @GetMapping(value = "/api/fuelstations", params = {"page", "size"})
  public Iterable<FuelStation> all(
      @RequestParam(value = "page", defaultValue = "0") int page,
      @RequestParam(value = "size", defaultValue = "20") int size) {

    return repository.findAll(new PageRequest(page, size));
  }

  @GetMapping("/api/fuelstations/{id}")
  FuelStation one(@PathVariable Long id) {

    return repository.findOne(id);
  }
}
