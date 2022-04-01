using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// manager for the scene.
public class Manager : MonoBehaviour
{
    // the display text.
    public GameObject textDisplay;

    // the container for the object.
    public GameObject container;

    // materials.
    [Header("Highlight Materials")]
    // these materials have their visibilities enabled when highlighted.

    // casing material.
    public Material casingMat;

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

    // Start is called before the first frame update
    void Start()
    {
        // turning off all the indicators.
        CasingMaterial = false;
        FlexSensorMaterial = false;
        VibratorMaterial = false;
        LEDMaterial = false;
        ArduinoMaterial = false;
        BreadboardMaterial = false;
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

    // Update is called once per frame
    void Update()
    {
        // hides/shows container.
        if (Input.GetKeyDown(KeyCode.H) && container != null)
        {
            container.SetActive(!container.activeSelf);
        }

        // hide/show text.
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            // display text is set.
            if(textDisplay != null)
            {
                // toggle visibility.
                textDisplay.SetActive(!textDisplay.activeSelf);
            }
        }

        // highlights container.
        if (Input.GetKeyDown(KeyCode.C))
        {
            ToggleCasingMaterial();
        }

        // flex sensor
        if(Input.GetKeyDown(KeyCode.F))
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
        if (Input.GetKeyDown(KeyCode.R))
        {
            ToggleArduinoMaterial();
        }

        // breadboard
        if (Input.GetKeyDown(KeyCode.B))
        {
            ToggleBreadboardMaterial();
        }


    }
}
