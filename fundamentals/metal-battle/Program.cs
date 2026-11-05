
using Spectre.Console;

int metallicaHP = 100;
int megadethHP = 100;
Random dice = new Random();

// TITLE
AnsiConsole.Write(
    new Rule("[magenta]BATALHA DE BANDAS[/]")
);

void DisplayBattle()
{
    // METALLICA
    var metallica = new Panel(
        new Markup(
            "[white]M      M[/]\n" +
            "[white]MM    MM[/]\n" +
            "[white]M M  M M[/]\n" +
            "[white]M  MM  M[/]\n" +
            "[white]M      M[/]\n\n" +
            "[white]METALLICA[/]\n" +
            $"[green]{Math.Max(0, metallicaHP)}/100 HP[/]"
        )
    )
    {
        Header = new PanelHeader(" METALLICA - Level 1 ")
    };

    // MEGADETH
    var dave = new Panel(
        new Markup(
            "[red]DDDDDDD[/]\n" +
            "[red]D      D[/]\n" +
            "[red]D       D[/]\n" +
            "[red]D      D[/]\n" +
            "[red]DDDDDDD[/]\n\n" +
            "[white]MEGADETH[/]\n" +
            $"[green]{Math.Max(0, megadethHP)}/100 HP[/]"
        )
    )
    {
        Header = new PanelHeader(" MEGADETH - Level 1 ")
    };

    // PANELS
    AnsiConsole.Write(new Columns(metallica, dave));
}

DisplayBattle();

do
{
    // MEGADETH ATTACK
    int roll = dice.Next(1, 101);
    metallicaHP -= roll;

    AnsiConsole.MarkupLine(
        $"[red]Megadeth dealt {roll} damage! Metallica is down to {Math.Max(0, metallicaHP)} HP. Oh nooo, not the legends![/]"
    );

    DisplayBattle();

    // CHECK IF METALLICA IS STILL ALIVE
    if (metallicaHP <= 0)
        break;

    // METALLICA ATTACK
    roll = dice.Next(1, 101);
    megadethHP -= roll;

    AnsiConsole.MarkupLine(
        $"[green]Metallica dealt {roll} damage! Megadeth is down to {Math.Max(0, megadethHP)} HP. What a tragedy![/]"
    );

    DisplayBattle();

} while (megadethHP > 0 && metallicaHP > 0);

// RESULTS
if (metallicaHP <= 0)
{
    AnsiConsole.MarkupLine("[red]MEGADETH WINS![/]");
}
else
{
    AnsiConsole.MarkupLine("[green]METALLICA WINS![/]");
}
