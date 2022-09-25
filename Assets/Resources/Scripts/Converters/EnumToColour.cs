using UnityEngine;

public static class EnumToColour {
    public static Color convert(Colour enumColour) {
        Color colour = Color.white;
        switch (enumColour) {
            case Colour.RED:
                colour = Constants.RED_COLOUR;
                break;
            case Colour.ORANGE:
                colour = Constants.ORANGE_COLOUR;
                break;
            case Colour.YELLOW:
                colour = Constants.YELLOW_COLOUR;
                break;
            case Colour.GREEN:
                colour = Constants.GREEN_COLOUR;
                break;
            case Colour.LIGHT_BLUE:
                colour = Constants.LIGHT_BLUE_COLOUR;
                break;
            case Colour.DARK_BLUE:
                colour = Constants.DARK_BLUE_COLOUR;
                break;
            case Colour.PURPLE:
                colour = Constants.PURPLE_COLOUR;
                break;
            case Colour.PINK:
                colour = Constants.PINK_COLOUR;
                break;
        }
        return colour;
    }
}
