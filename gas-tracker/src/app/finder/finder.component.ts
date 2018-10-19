import { Component, OnInit } from '@angular/core';
import { StationService } from '../station.service';

@Component({
  selector: 'app-finder',
  templateUrl: './finder.component.html',
  styleUrls: ['./finder.component.css'],
  providers: [StationService]
})
export class FinderComponent implements OnInit {

  constructor(private apiService: StationService) { }

  stations: any;
  address: string;
  fuelType: string;
  isSearching = false;

  ngOnInit() {
  }

  search() {
    this.isSearching = true;
    this.apiService.getStations(this.address, this.fuelType).toPromise().then(data => {
      this.isSearching = false;
      this.stations = data;
    });
  }

  map(latitude: string, longitude: string) {
    window.open(`https://www.google.com/maps/search/?api=1&query=${latitude},${longitude}`, "_blank");
  }

  randomPrice() {
    return (Math.random() * (3.89 - 2.09) + 2.09).toFixed(2);
  }

}
