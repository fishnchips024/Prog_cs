namespace Project;

class Global
{
    public static Stanza[][] map = new Stanza[][]{};

    public static void Inizializza(Giocatore player)
    {
        // ====================================================================
        // 1. MAPPE CON CARATTERI FILLER (PUNTINI STELLARI) PER BLOCCARE L'ALLINEAMENTO
        // ====================================================================

        string mapSComandi = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../         >SEI QUI<         \
        +---------╳-------------+───────╱───────+─────────╱────+---------+
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +---------+─────────────┼───────────────┼─────────────+---------+
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────+─────────────┼───────╱───────┼─────────────+-────────+
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapCNord = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────────────┼───────╱───────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   >SEI QUI<   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +---------+─────────────┼───────────────┼─────────────+---------+
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +---------+─────────────+───────╱───────+─────────────+---------+
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapCSud = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────────────┼───────────────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   >SEI QUI<   |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +---------+─────────────┼───────────────┼─────────────+---------+
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────+─────────────┼───────╱───────┼─────────────+-────────+
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapONord = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────╱───────┼───────────────┼──────────╱─┤
        |         |             |               |             |         |
        |>SEI QUI<| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +-────────╱───────┼───────────────┼──────────╱─┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +---------+─────────────+───────────────+─────────────+---------+
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapOSud = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────╱───────┼───────────────┼──────────╱─┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   >SEI QUI<   |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +-────────╱───────┼───────────────┼──────────╱─┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────+─────────────┼───────╱───────┼─────────────+-────────+
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapENord = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────────────┼───────╱───────┼──────────╱─┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |>SEI QUI<|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +-────────+─────────────┼───────────────┼──────────╱──┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────+─────────────┼───────────────┼──────────╱──┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapESud = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-──���─────+─────────────┼───────────────┼──────────╱──┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|>SEI QUI<|
        |         |             |               |             |         |
        +-────────+─────────────┼───────╱───────┼──────────╱──┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────+─────────────┼───────��───────┼─────────────+-────────+
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapRipostiglio = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────╱───────┼───────────────┼──────────╱─┤
        |         |             |               |             |         |
        |CORRIDOIO|  >SEI QUI<  |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +-────────╱───────┼───────────────┼──────────╱─┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +---------+─────────────+───────────────+─────────────+---------+
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapMedica = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────╱───────┼───────────────┼──────────╱─┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  |  >SEI QUI<  |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +-────────╱───────┼───────────────┼──────────╱─┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +---------+─────────────+───────────────+─────────────+---------+
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapArchivio = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-─────────────╱──┼───────────────┼──────────╱─┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  >SEI QUI<  |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +-────────┼──────────╱──┼───────────────┼──────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +---------+─────────────+───────╱───────+─────────────+---------+
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapOssigeno = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼──────────╱──┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |  >SEI QUI<  |   EST   |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────────────┼──────────╱──┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────+─────────────┼───────╱───────┼─────────────+-────────+
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapMotoriO1 = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼─────────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────────────┼──────────────┤
        |         :             |               |             :         |
        |>SEI QUI<:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────╱─────────────┼───────╱───────┼─────────────+-────────+
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapMotoriO2 = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-─────────────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +-─────────────────┼───────────────┼──────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  >SEI QUI<  |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────╱─────────────┼───────╱───────┼───────╱─────+-────────+
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapMagazzino = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-─────────────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +-─────────────────┼───────────────┼──────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   >SEI QUI<   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────╱─────────────┼───────╱───────┼───────╱─────+-────────+
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapMotoriE1 = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-─────────────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +-─────────────────┼───────────────┼──────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  >SEI QUI<  : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼───────╱─────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapMotoriE2 = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-─────────────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +-─────────────────┼───────────────┼──────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   :>SEI QUI<|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────────────┼───────╱─────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapPorto = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-─────────────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +-─────────────────┼───────────────┼──────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|>SEI QUI<      |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapNavetta = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-─────────────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +-─────────────────┼───────────────┼──────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────────────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(  >SEI QUI<    )
        ........................(    NAVETTA    )
        .........................'─────────────'";


        // ====================================================================
        // 2. CREAZIONE DELLE STANZE CON LA MAPPA CORRISPONDENTE
        // ====================================================================
        Stanza salaComandi = new Stanza("Sala Comandi", "Il ponte di comando della nave. Un'enorme vetrata mostra lo spazio siderale.", mapSComandi);

        Stanza corrOvestN = new Stanza("Corridoio Ovest (Nord)", "La parte nord del corridoio di babordo.", mapONord);
        Stanza ripostiglio = new Stanza("Ripostiglio", "Una piccola stanza piena di attrezzi per la manutenzione.", mapRipostiglio);
        Stanza corrCentraleN = new Stanza("Corridoio Centrale (Nord)", "L'arteria principale della nave.", mapCNord);
        Stanza archivio = new Stanza("Archivio", "Server spenti e faldoni digitali coprono le pareti.", mapArchivio);
        Stanza corrEstN = new Stanza("Corridoio Est (Nord)", "La parte nord del corridoio di tribordo.", mapENord);

        Stanza corrOvestS = new Stanza("Corridoio Ovest (Sud)", "La parte sud del corridoio di babordo.", mapOSud);
        Stanza salaMedica = new Stanza("Sala Medica", "Lettini d'emergenza e macchinari medici.", mapMedica);
        Stanza corrCentraleS = new Stanza("Corridoio Centrale (Sud)", "Il corridoio principale. Da qui si scende verso la stiva.", mapCSud);
        Stanza salaOssigeno = new Stanza("Sala Ossigeno", "Enormi ventole purificano l'aria della nave.", mapOssigeno);
        Stanza corrEstS = new Stanza("Corridoio Est (Sud)", "La parte sud del corridoio di tribordo.", mapESud);

        Stanza motoriOvest1 = new Stanza("Sala Motori Ovest 1 (Esterna)", "La parte più esterna del reattore di sinistra.", mapMotoriO1);
        Stanza motoriOvest2 = new Stanza("Sala Motori Ovest 2 (Interna)", "La parte interna del reattore di sinistra, vicino al magazzino.", mapMotoriO2);
        Stanza magazzino = new Stanza("Magazzino", "Casse impilate l'una sull'altra bloccano parzialmente la visuale.", mapMagazzino);
        Stanza motoriEst1 = new Stanza("Sala Motori Est 1 (Interna)", "La parte interna del reattore di destra, vicino al magazzino.", mapMotoriE1);
        Stanza motoriEst2 = new Stanza("Sala Motori Est 2 (Esterna)", "La parte più esterna del reattore di destra.", mapMotoriE2);

        Stanza porto = new Stanza("Porto di Sbarco", "La camera di compensazione e attracco navette.", mapPorto);
        Stanza navetta = new Stanza("Navetta", "Il veicolo con cui siete arrivati. I motori sono spenti.", mapNavetta);
        
        // === AGGIUNTA DEI TERMINALI - TEST DI TUTTI E TRE GLI STATI ===
        
        // TERMINALE 1: BLOCCATO (richiede password "1234")
        Terminale terminaleMagazzino = new Terminale("Terminale Logistico", "Un terminale bloccato da password.", StatoTerminale.Bloccato, "1234");
        terminaleMagazzino.logs.Add("MEMO: Smettetela di usare '1234' come password per il magazzino!");
        terminaleMagazzino.logs.Add("AVVISO: Accesso limitato - Verificare credenziali.");
        magazzino.lista.Add(terminaleMagazzino);

        // TERMINALE 2: CRIPTATO (richiede il minigioco Breach Protocol)
        Terminale terminaleOssigeno = new Terminale("Terminale Ambientale", "Il quadro dei comandi vitale. Il sistema è criptato e richiede una violazione.", StatoTerminale.Criptato, "");
        terminaleOssigeno.logs.Add("AVVISO SISTEMA: Rilevato blocco porte.");
        terminaleOssigeno.logs.Add("AUTORITÀ: Protezione crittografica attivata.");
        terminaleOssigeno.logs.Add("NOTA: Tempo limite di vulnerabilità: 30 secondi.");
        salaOssigeno.lista.Add(terminaleOssigeno);

        // TERMINALE 3: SBLOCCATO (accesso immediato)
        Terminale terminaleArchivio = new Terminale("Terminale Archivi", "Un vecchio terminale già sbloccato dal precedente operatore.", StatoTerminale.Sbloccato, "");
        terminaleArchivio.logs.Add("ULTIMO ACCESSO: 72 ore fa");
        terminaleArchivio.logs.Add("STATO: Sistema operativo attivo");
        terminaleArchivio.logs.Add("DATABASE: Dati di navigazione, coordinate stellari, rapporti storici");
        terminaleArchivio.logs.Add("AVVISO: Backup programmato per domani 06:00");
        archivio.lista.Add(terminaleArchivio);

        // ====================================================================
        // 3. CONFIGURAZIONE DELLE PORTE - SECONDO LO SCHEMA SPECIFICATO
        // ====================================================================
        // Le porte collegano le stanze secondo lo schema fornito
        // Le porte sono SEMPRE APERTE per ora
        
        // 1. NAVETTA <-> PORTO (Nord da Navetta, Sud da Porto)
        Porta portaNavettaPorto = new Porta("Porta Navetta-Porto", Porta.StatoPorta.Aperta);
        navetta.portaNord = portaNavettaPorto;
        porto.portaSud = portaNavettaPorto;

        // 2. PORTO <-> MAGAZZINO (Nord da Porto, Sud da Magazzino)
        Porta portaPortoMagazzino = new Porta("Porta Porto-Magazzino", Porta.StatoPorta.Aperta);
        porto.portaNord = portaPortoMagazzino;
        magazzino.portaSud = portaPortoMagazzino;

        // 3. MAGAZZINO <-> SALA MOTORI OVEST 1 (Ovest da Magazzino, Est da MotoriOvest1)
        Porta portaMagazzinoMotoriO1 = new Porta("Porta Magazzino-MotoriOvest1", Porta.StatoPorta.Aperta);
        magazzino.portaOvest = portaMagazzinoMotoriO1;
        motoriOvest1.portaEst = portaMagazzinoMotoriO1;

        // 4. MAGAZZINO <-> SALA MOTORI EST 1 (Est da Magazzino, Ovest da MotoriEst1)
        Porta portaMagazzinoMotoriE1 = new Porta("Porta Magazzino-MotoriEst1", Porta.StatoPorta.Aperta);
        magazzino.portaEst = portaMagazzinoMotoriE1;
        motoriEst1.portaOvest = portaMagazzinoMotoriE1;

        // 5. SALA MOTORI EST 1 <-> SALA OSSIGENO (Nord da MotoriEst1, Sud da Ossigeno)
        Porta portaMotoriE1Ossigeno = new Porta("Porta MotoriEst1-Ossigeno", Porta.StatoPorta.Aperta);
        motoriEst1.portaNord = portaMotoriE1Ossigeno;
        salaOssigeno.portaSud = portaMotoriE1Ossigeno;

        // 6. SALA MOTORI EST 2 <-> CORRIDOIO EST (Sud) (Est da MotoriEst2, Ovest da CorrEstS)
        Porta portaMotoriE2CorrEstS = new Porta("Porta MotoriEst2-CorrEstS", Porta.StatoPorta.Aperta);
        motoriEst2.portaOvest = portaMotoriE2CorrEstS;
        corrEstS.portaEst = portaMotoriE2CorrEstS;

        // 7. CORRIDOIO EST (Nord) <-> ARCHIVIO (Ovest da CorrEstN, Est da Archivio)
        Porta portaCorrEstNArchivio = new Porta("Porta CorrEstN-Archivio", Porta.StatoPorta.Aperta);
        corrEstN.portaOvest = portaCorrEstNArchivio;
        archivio.portaEst = portaCorrEstNArchivio;

        // 8. ARCHIVIO <-> CORRIDOIO CENTRALE (Nord) (Ovest da Archivio, Est da CorrCentraleN)
        Porta portaArchivioCC = new Porta("Porta Archivio-CorrCentraleN", Porta.StatoPorta.Aperta);
        archivio.portaOvest = portaArchivioCC;
        corrCentraleN.portaEst = portaArchivioCC;

        // 9. CORRIDOIO CENTRALE NORD <-> RIPOSTIGLIO (Ovest da CorrCentraleN, Est da Ripostiglio)
        Porta portaCCNRipostiglio = new Porta("Porta CorrCentraleN-Ripostiglio", Porta.StatoPorta.Aperta);
        corrCentraleN.portaOvest = portaCCNRipostiglio;
        ripostiglio.portaEst = portaCCNRipostiglio;

        // 10. RIPOSTIGLIO <-> CORRIDOIO OVEST (Nord) (Ovest da Ripostiglio, Est da CorrOvestN)
        Porta portaRipostCorrOvestN = new Porta("Porta Ripostiglio-CorrOvestN", Porta.StatoPorta.Aperta);
        ripostiglio.portaOvest = portaRipostCorrOvestN;
        corrOvestN.portaEst = portaRipostCorrOvestN;

        // 11. CORRIDOIO OVEST (Nord) <-> CORRIDOIO OVEST (Sud) (Sud da CorrOvestN, Nord da CorrOvestS)
        Porta portaCorrOvestNS = new Porta("Porta CorrOvestN-CorrOvestS", Porta.StatoPorta.Aperta);
        corrOvestN.portaSud = portaCorrOvestNS;
        corrOvestS.portaNord = portaCorrOvestNS;

        // 12. CORRIDOIO OVEST (Sud) <-> SALA MEDICA (Est da CorrOvestS, Ovest da SalaMedica)
        Porta portaCorrOvestSSalaMedica = new Porta("Porta CorrOvestS-SalaMedica", Porta.StatoPorta.Aperta);
        corrOvestS.portaEst = portaCorrOvestSSalaMedica;
        salaMedica.portaOvest = portaCorrOvestSSalaMedica;

        // === PORTE APERTE TRA CORRIDOI (Divisioni logiche della stessa area) ===
        
        // 13. Corridoio Centrale Nord <-> Corridoio Centrale Sud
        Porta portaCCNordicS = new Porta("Porta CorrCentraleN-CorrCentraleS", Porta.StatoPorta.Aperta);
        corrCentraleN.portaSud = portaCCNordicS;
        corrCentraleS.portaNord = portaCCNordicS;

        // 14. Corridoio Est Nord <-> Corridoio Est Sud
        Porta portaCorrEstNS = new Porta("Porta CorrEstN-CorrEstS", Porta.StatoPorta.Aperta);
        corrEstN.portaSud = portaCorrEstNS;
        corrEstS.portaNord = portaCorrEstNS;

        // 15. Sala Medica <-> Corridoio Centrale Sud
        Porta portaSalaMedicaCC = new Porta("Porta SalaMedica-CorrCentraleS", Porta.StatoPorta.Aperta);
        salaMedica.portaEst = portaSalaMedicaCC;
        corrCentraleS.portaOvest = portaSalaMedicaCC;

        // 16. Sala Ossigeno <-> Corridoio Centrale Sud
        Porta portaSalaOssigenoCC = new Porta("Porta SalaOssigeno-CorrCentraleS", Porta.StatoPorta.Aperta);
        salaOssigeno.portaOvest = portaSalaOssigenoCC;
        corrCentraleS.portaEst = portaSalaOssigenoCC;

        // 17. Corridoio Centrale Nord <-> Sala Comandi (Nord da CorrCentraleN, Sud da SalaComandi)
        Porta portaCCNSalaComandi = new Porta("Porta CorrCentraleN-SalaComandi", Porta.StatoPorta.Aperta);
        corrCentraleN.portaNord = portaCCNSalaComandi;
        salaComandi.portaSud = portaCCNSalaComandi;

        // 18. Motori Ovest 1 <-> Motori Ovest 2 (Est da MotoriOvest1, Ovest da MotoriOvest2)
        Porta portaMotoriO1O2 = new Porta("Porta MotoriOvest1-MotoriOvest2", Porta.StatoPorta.Aperta);
        motoriOvest1.portaOvest = portaMotoriO1O2;
        motoriOvest2.portaEst = portaMotoriO1O2;

        // 19. Magazzino <-> Motori Ovest 2 (Nord da MotoriOvest2, Sud da Magazzino)
        Porta portaMotoriO2Magazzino = new Porta("Porta MotoriOvest2-Magazzino", Porta.StatoPorta.Aperta);
        motoriOvest2.portaNord = portaMotoriO2Magazzino;
        magazzino.portaOvest = portaMotoriO2Magazzino;

        // 20. Motori Est 1 <-> Motori Est 2 (Est da MotoriEst1, Nord da MotoriEst2)
        Porta portaMotoriE1E2 = new Porta("Porta MotoriEst1-MotoriEst2", Porta.StatoPorta.Aperta);
        motoriEst1.portaEst = portaMotoriE1E2;
        motoriEst2.portaNord = portaMotoriE1E2;

        // ====================================================================
        // 4. INSERIMENTO NELLA GRIGLIA LOGICA (6 Righe, 5 Colonne)
        // ====================================================================
        map = new Stanza[][] {
            /* Riga 0 */ new Stanza[] { null, null, salaComandi, null, null },
            /* Riga 1 */ new Stanza[] { corrOvestN, ripostiglio, corrCentraleN, archivio, corrEstN },
            /* Riga 2 */ new Stanza[] { corrOvestS, salaMedica, corrCentraleS, salaOssigeno, corrEstS },
            /* Riga 3 */ new Stanza[] { motoriOvest1, motoriOvest2, magazzino, motoriEst1, motoriEst2 },
            /* Riga 4 */ new Stanza[] { null, null, porto, null, null },
            /* Riga 5 */ new Stanza[] { null, null, navetta, null, null }
        };

        // Oggetto iniziale di test
        player.inventario.Push(new Oggetto("Chiave Inglese", "Pesante e arrugginita.", 1.5f, true));

        // Partiamo dalla navetta (Riga 5, Colonna 2)
        player.coordinate = new int[] { 5, 2 };
        player.stanza = navetta;
    }
}
