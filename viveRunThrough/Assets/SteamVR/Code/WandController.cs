using UnityEngine;
using System.Collections;

public class WandController : SteamVR_TrackedController {

  public SteamVR_Controller.Device controller { get { return SteamVR_Controller.input((int) controllerIndex); }}
  public Vector3 velocity { get {return controllerIndex.velocity; } }
  public Vector3 angularVelocity { get {return controller.angularVelocity; } }

  protected override void Start() {
    base.Start();
  }

  protected override void Update() {
    base.Update();
  }

  public override void OnTriggerClicked(ClickedEventArgs e) {
    base.OnTriggerClicked(e);
  }

  public override void OnTriggerUnclicked(ClickedEventArgs e) {
    base.OnTriggerUnclicked(e);
  }

  public override void OnMenuClicked(ClickedEventArgs e) {
    base.OnMenuClicked(e);
  }

  public override void OnMenuUnclicked(ClickedEventArgs e) {
    base.OnMenuUnclicked(e);
  }

  public override void OnSteamClicked(ClickedEventArgs e) {
    base.OnSteamClicked(e);
  }

  public override void OnPadClicked(ClickedEventArgs e) {
    base.OnPadClicked(e);
  }

  public override void OnPadUnclicked(ClickedEventArgs e) {
    base.OnPadUnclicked(e);
  }

  public override void OnPadTouched(ClickedEventArgs e) {
    base.OnPadTouched(e);
  }

  public override void OnPadUntouched(ClickedEventArgs e) {
    base.OnPadUntouched(e);
  }

  public override void OnGripped(ClickedEventArgs e) {
    base.OnGripped(e);
  }

  public override void OnUngripped(ClickedEventArgs e) {
    base.OnUngripped(e);
  }
}
