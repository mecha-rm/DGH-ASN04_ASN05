using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// TODO: restore materials to their defaults.

// manager for the scene.
public class Manager : MonoBehaviour
{
    // the haptic glove model.
    public Model model;

    // the display text.
    public GameObject textDisplay;

    // the container for the object.
    public GameObject container;

    // the collider object.
    public GameObject colliderObject;

    // reset position for the collider object.
    public Vector3 colObjectResetPos;

    // the collider platform.
    public GameObject colliderPlatform;

    // materials.
    [Header("Highlight Materials")]
    // these materials have their visibilities enabled when highlighted.

    // casing material.
    public Material casingMat;

    // the button material.
    public Material buttonMat;

    // flex sensor material.
    public Material flexSensorMat;

    // vibrator materials.
    public Material vibratorMat;

    // the LED material.
    public Material ledMat;

    // the arduino material.
    public Material arduinoMat;

    // the breadboard material.
    public Material breadboardMat;

    // the battery material.
    public Material batteryMat;

    // the material for collisions.
    public Material collisionMat;

    // Start is called before the first frame update
    void Start()
    {
        // finds the model.
        if (model == null)
            model = FindObjectOfType<Model>();

        // disables all the highlight materials to start off.
        DisableAllHighlightMaterials();

        // saves the reset position.
        if (colliderObject != null)
            colObjectResetPos = colliderObject.transform.position;
    }

    // these don't get triggered since the collider doesn't have a hitbox.

    // entered a collision.
    private void OnCollisionEnter(Collision collision)
    {
        CollisionMaterial = true;
    }

    // left a collision.
    private void OnCollisionExit(Collision collision)
    {
        CollisionMaterial = false;
    }

    // checks if the material is visible.
    public bool IsMaterialVisible(Color color)
    {
        return color.a == 1.0F;
    }

    // sets the material visible.
    public Color SetMaterialVisible(Color color, bool value)
    {
        // changes the alpha value.
        if (value)
            color.a = 1.0F;
        else
            color.a = 0.0F;

        return color;
    }
    
    // enables all the highlight materials.
    public void EnableAllHighlightMaterials()
    {
        // turning off all the indicators.
        CasingMaterial = true;
        ButtonMaterial = true;
        FlexSensorMaterial = true;
        VibratorMaterial = true;
        LEDMaterial = true;
        ArduinoMaterial = true;
        BreadboardMaterial = true;
        BatteryMaterial = true;

        // the collider material
        CollisionMaterial = true;
    }

    // disables all the highlight materials.
    public void DisableAllHighlightMaterials()
    {
        // turning off all the indicators.
        CasingMaterial = false;
        ButtonMaterial = false;
        FlexSensorMaterial = false;
        VibratorMaterial = false;
        LEDMaterial = false;
        ArduinoMaterial = false;
        BreadboardMaterial = false;
        BatteryMaterial = false;

        // the collider material
        CollisionMaterial = false;
    }

    // CASING MATERIAL //
    public bool CasingMaterial
    {
        get
        {
            return IsMaterialVisible(casingMat.color);
        }

        set
        {
            casingMat.color = SetMaterialVisible(casingMat.color, value);
        }
    }

    // toggles the casing material.
    public void ToggleCasingMaterial()
    {
        // toggling the casing material.
        if (CasingMaterial)
            CasingMaterial = false;
        else
            CasingMaterial = true;
    }

    // BUTTON MATERIAL //
    public bool ButtonMaterial
    {
        get
        {
            return IsMaterialVisible(buttonMat.color);
        }

        set
        {
            buttonMat.color = SetMaterialVisible(buttonMat.color, value);
        }
    }

    // toggles the button material.
    public void ToggleButtonMaterial()
    {
        // toggling the button material.
        if (ButtonMaterial)
            ButtonMaterial = false;
        else
            ButtonMaterial = true;
    }

    // FLEX SENSOR MATERIAL //
    public bool FlexSensorMaterial
    {
        get
        {
            return IsMaterialVisible(flexSensorMat.color);
        }

        set
        {
            flexSensorMat.color = SetMaterialVisible(flexSensorMat.color, value);
        }
    }

    // toggles the flex sensor material.
    public void ToggleFlexSensorMaterial()
    {
        // toggling the casing material.
        if (FlexSensorMaterial)
            FlexSensorMaterial = false;
        else
            FlexSensorMaterial = true;
    }

    // VIBRATOR MATERIAL //
    public bool VibratorMaterial
    {
        get
        {
            return IsMaterialVisible(vibratorMat.color);
        }

        set
        {
            vibratorMat.color = SetMaterialVisible(vibratorMat.color, value);
        }
    }

    // toggles the vibrator material.
    public void ToggleVibratorMaterial()
    {
        // toggling the vibrator material.
        if (VibratorMaterial)
            VibratorMaterial = false;
        else
            VibratorMaterial = true;
    }

    // LED MATERIAL //
    public bool LEDMaterial
    {
        get
        {
            return IsMaterialVisible(ledMat.color);
        }

        set
        {
            ledMat.color = SetMaterialVisible(ledMat.color, value);
        }
    }

    // toggles the LED material.
    public void ToggleLEDMaterial()
    {
        // toggling the LED material.
        if (LEDMaterial)
            LEDMaterial = false;
        else
            LEDMaterial = true;
    }

    // ARDUINO MATERIAL //
    public bool ArduinoMaterial
    {
        get
        {
            return IsMaterialVisible(arduinoMat.color);
        }

        set
        {
            arduinoMat.color = SetMaterialVisible(arduinoMat.color, value);
        }
    }

    // toggles the arduino material.
    public void ToggleArduinoMaterial()
    {
        // toggling the arduino material.
        if (ArduinoMaterial)
            ArduinoMaterial = false;
        else
            ArduinoMaterial = true;
    }

    // BREADBOARD MATERIAL //
    public bool BreadboardMaterial
    {
        get
        {
            return IsMaterialVisible(breadboardMat.color);
        }

        set
        {
            breadboardMat.color = SetMaterialVisible(breadboardMat.color, value);
        }
    }

    // toggles the breadboard material.
    public void ToggleBreadboardMaterial()
    {
        // toggling the breadboard material.
        if (BreadboardMaterial)
            BreadboardMaterial = false;
        else
            BreadboardMaterial = true;
    }

    // BATTERY MATERIAL //
    public bool BatteryMaterial
    {
        get
        {
            return IsMaterialVisible(batteryMat.color);
        }

        set
        {
            batteryMat.color = SetMaterialVisible(batteryMat.color, value);
        }
    }

    // toggles the battery material.
    public void ToggleBatteryMaterial()
    {
        // toggling the battery material.
        if (BatteryMaterial)
            BatteryMaterial = false;
        else
            BatteryMaterial = true;
    }

    // COLLISION MATERIAL //
    public bool CollisionMaterial
    {
        get
        {
            return IsMaterialVisible(collisionMat.color);
        }

        set
        {
            collisionMat.color = SetMaterialVisible(collisionMat.color, value);
        }
    }

    // toggles the collision material.
    public void ToggleCollisionMaterial()
    {
        // toggling the LED material.
        if (CollisionMaterial)
            CollisionMaterial = false;
        else
            CollisionMaterial = true;
    }

    // Update is called once per frame
    void Update()
    {
        // hides/shows container.
        if (Input.GetKeyDown(KeyCode.H) && container != null)
        {
            container.SetActive(!container.activeSelf);
        }

        // hide/show text.
        if(Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
        {
            // display text is set.
            if(textDisplay != null)
            {
                // toggle visibility.
                textDisplay.SetActive(!textDisplay.activeSelf);
            }
        }

        // HIGHLIGHTS
        // toggles on and off highlights.
        
        // container
        if (Input.GetKeyDown(KeyCode.C))
        {
            ToggleCasingMaterial();
        }

        // button
        if (Input.GetKeyDown(KeyCode.O))
        {
            ToggleButtonMaterial();
        }

        // flex sensor
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleFlexSensorMaterial();
        }

        // vibrator
        if (Input.GetKeyDown(KeyCode.V))
        {
            ToggleVibratorMaterial();
        }

        // LED
        if (Input.GetKeyDown(KeyCode.L))
        {
            ToggleLEDMaterial();
        }

        // arduino
        if (Input.GetKeyDown(KeyCode.U))
        {
            ToggleArduinoMaterial();
        }

        // breadboard
        if (Input.GetKeyDown(KeyCode.B))
        {
            ToggleBreadboardMaterial();
        }

        // battery (li polymer battery)
        if (Input.GetKeyDown(KeyCode.P))
        {
            ToggleBatteryMaterial();
        }


        // spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // toggle active.
            if (colliderPlatform != null)
                colliderPlatform.SetActive(!colliderPlatform.activeSelf);

            // if the collider platform is now active, reset hte collision object.
            if(colliderPlatform.activeSelf)
            {
                colliderObject.transform.position = colObjectResetPos;
            }
        }

        // checks model for active collision.
        // this isn't efficient, but it shouldn't be a problem.
        if(model != null && colliderObject != null)
        {
            CollisionMaterial = model.colliding;
        }
    }

    // enables all the materials when the application is ending.
    private void OnApplicationQuit()
    {
        // enables all the materials.
        EnableAllHighlightMaterials();
    }
}
