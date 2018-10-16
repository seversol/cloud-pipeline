package cp;

import javax.persistence.Entity;

import javax.persistence.Id;
import lombok.Data;

@Entity
@Data
public class FuelStation {

  @Id
  private long id;
  private String access_days_time;
  private String cards_accepted;
  private String date_last_confirmed;
  private String expected_date;
  private String fuel_type_code;
  private String groups_with_access_code;
  private String open_date;
  private String owner_type_code;
  private String status_code;
  private String station_name;
  private String station_phone;
  private String updated_at;
  private String geocode_status;
  private String latitude;
  private String longitude;
  private String city;
  private String intersection_directions;
  private String plus4;
  private String state;
  private String street_address;
  private String zip;
  private String bd_blends;
  private String e85_blender_pump;
  private String ev_connector_types;
  private String ev_dc_fast_num;
  private String ev_level1_evse_num;
  private String ev_level2_evse_num;
  private String ev_network;
  private String ev_network_web;
  private String ev_other_evse;
  private String hy_status_link;
  private String lpg_primary;
  private String ng_fill_type_code;
  private String ng_psi;
  private String ng_vehicle_class;
}
