import { Box, Grid, Button } from "@mui/material";
import DropMultiSelect from "../Components/DropMultiSelect";
import { Text, Header } from "../Components/Label";
import InputComponent from "../Components/InputComponent";
import { useState } from "react";
import TextInput from "../Components/TextInput";
import {
  getAudiences,
  getMissions,
  getPlacesOfIntervention,
} from "../utils/BackendFunctions";
import { SingleCheckbox } from "../Components/Checkbox";
import {
  isEmail,
  isName,
  isPostalCode,
  isTelephoneNumber,
} from "../utils/checkFunctions";
import { Address, ContactPerson, Professional } from "../utils/Entities";

export default function Form() {
  const [name, setName] = useState("");
  const [nameError, setNameError] = useState(false);
  const [establishmentType, setEstablishmentType] = useState("");
  const [establishmentTypeError, setEstablishmentTypeError] = useState(false);
  const [managementType, setManagementType] = useState("");
  const [managementTypeError, setManagementTypeError] = useState(false);
  const [telephone, setTelephone] = useState("");
  const [telephoneError, setTelephoneError] = useState(false);
  const [street, setStreet] = useState("");
  const [streetError, setStreetError] = useState(false);
  const [city, setCity] = useState("");
  const [cityError, setCityError] = useState(false);
  const [postal, setPostal] = useState("");
  const [postalError, setPostalError] = useState(false);
  const [mail, setMail] = useState("");
  const [mailError, setMailError] = useState(false);
  const [contactPersonName, setContactPersonName] = useState("");
  const [contactPersonNameError, setContactPersonNameError] = useState(false);
  const [contactPersonTelephone, setContactPersonTelephone] = useState("");
  const [contactPersonTelephoneError, setContactPersonTelephoneError] =
    useState(false);
  const [contactPersonEmail, setContactPersonEmail] = useState("");
  const [contactPersonEmailError, setContactPersonEmailError] = useState(false);
  const [contactPersonFunction, setContactPersonFunction] = useState("");
  const [contactPersonFunctionError, setContactPersonFunctionError] =
    useState(false);
  const [audiences, setAudiences] = useState([]);
  const [audiencesError, setAudiencesError] = useState(false);
  const [missions, setMissions] = useState([]);
  const [missionsError, setMissionsError] = useState(false);
  const [placesOfIntervention, setPlacesOfIntervention] = useState([]);
  const [placesOfInterventionError, setPlacesOfInterventionError] =
    useState(false);
  const [description, setDescription] = useState("");
  const [descriptionError, setDescriptionError] = useState(false);
  const [accept, setAccept] = useState(false);
  const [acceptError, setAcceptError] = useState(false);

  const onSubmit = function () {
    let success = checkEntries();
    if (success) {
      let professional = createProfessinalEntitiy();
      console.log(professional);
    }
  };

  const checkEntries = function () {
    let checkSuccess = true;
    // Name
    if (!isName(name)) {
      setNameError(true);
      checkSuccess = false;
    }
    // Establishment Type
    if (!isName(establishmentType)) {
      setEstablishmentTypeError(true);
      checkSuccess = false;
    }
    // Management Type
    if (!isName(managementType)) {
      setManagementTypeError(true);
      checkSuccess = false;
    }
    // Telephonenumber
    if (!isTelephoneNumber(telephone)) {
      setTelephoneError(true);
      checkSuccess = true;
    }
    // Streetname
    if (!isName(street)) {
      setStreetError(true);
      checkSuccess = false;
    }
    // City
    if (!isName(city)) {
      setCityError(true);
      checkSuccess = false;
    }
    // PostalCode
    if (!isPostalCode(postal)) {
      setPostalError(true);
      checkSuccess = false;
    }
    // Mail
    if (!isEmail(mail)) {
      setMailError(true);
      checkSuccess = false;
    }
    // Name Contact Person
    if (!isName(contactPersonName)) {
      setContactPersonNameError(true);
      checkSuccess = false;
    }
    // Telephone Contact Person
    if (!isTelephoneNumber(contactPersonTelephone)) {
      setContactPersonTelephoneError(true);
      checkSuccess = false;
    }
    // Mail Contact Person
    if (!isEmail(contactPersonEmail)) {
      setContactPersonEmailError(true);
      checkSuccess = false;
    }
    // Function Contact Person
    if (!isName(contactPersonFunction)) {
      setContactPersonFunctionError(true);
      checkSuccess = false;
    }
    //Audiences
    if (audiences.length == 0) {
      setAudiencesError(true);
      checkSuccess = false;
    }
    //Missions
    if (missions.length == 0) {
      setMissionsError(true);
      checkSuccess = false;
    }
    //PlaceOfInterventions
    if (placesOfIntervention.length === 0) {
      setPlacesOfInterventionError(true);
      checkSuccess = false;
    }
    // Description
    if (!isName(description)) {
      setDescriptionError(true);
      checkSuccess = false;
    }
    // Accepted Licence
    if (!accept) {
      setAcceptError(true);
      checkSuccess = false;
    }
    return checkSuccess;
  };

  const createProfessinalEntitiy = function () {
    const address = new Address(street, city, postal);
    const contactPerson = new ContactPerson(
      contactPersonName,
      contactPersonTelephone,
      contactPersonEmail,
      contactPersonFunction
    );
    const professional = new Professional(
      null,
      name,
      establishmentType,
      managementType,
      address,
      telephone,
      null,
      mail,
      contactPerson,
      audiences,
      placesOfIntervention,
      missions,
      description
    );
    return professional;
  };

  return (
    <Box>
      <Header>Veuillez remplir le formulaire suivant.</Header>
      <Text>
        Avec une inscription confirmée, vous entrez dans notre service de
        recherche et d'identification dans le domaine professionnel des
        handicaps de la petite enfance.
      </Text>

      <Grid paddingX={10} container spacing={2}>
        <Grid item xs={12}>
          <Text>Information de votre structure</Text>
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={nameError}
            setTextState={setName}
            setErrorState={setNameError}
            label="Nom de la structure"
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={establishmentTypeError}
            setTextState={setEstablishmentType}
            setErrorState={setEstablishmentTypeError}
            label="Service"
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={managementTypeError}
            setTextState={setManagementType}
            setErrorState={setManagementTypeError}
            label="Gestionnaire"
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={telephoneError}
            setTextState={setTelephone}
            setErrorState={setTelephoneError}
            label="Numero téléphone"
          />
        </Grid>

        <Grid item xs={12} sm={6}>
          <TextInput
            error={streetError}
            setTextState={setStreet}
            setErrorState={setStreetError}
            label="Street"
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={cityError}
            setTextState={setCity}
            setErrorState={setCityError}
            label="City"
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={postalError}
            setTextState={setPostal}
            setErrorState={setPostalError}
            label="Postal"
          />
        </Grid>

        <Grid item xs={12} sm={6}>
          <TextInput
            error={mailError}
            setTextState={setMail}
            setErrorState={setMailError}
            label="Mail"
          />
        </Grid>
        <Grid item xs={12}>
          <Text>Information de la personne ressource</Text>
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={contactPersonNameError}
            setTextState={setContactPersonName}
            setErrorState={setContactPersonNameError}
            label="Nom contact personne"
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={contactPersonTelephoneError}
            setTextState={setContactPersonTelephone}
            setErrorState={setContactPersonTelephoneError}
            label="Numero téléphone contact personne"
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={contactPersonEmailError}
            setTextState={setContactPersonEmail}
            setErrorState={setContactPersonEmailError}
            label="Email contact personne"
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={contactPersonFunctionError}
            setTextState={setContactPersonFunction}
            setErrorState={setContactPersonFunctionError}
            label="function contact personne"
          />
        </Grid>
        <Grid item xs={12}>
          <Text>Champs d'intervention</Text>
        </Grid>
        <Grid item xs={12} sm={6}>
          <DropMultiSelect
            options={getAudiences()}
            error={audiencesError}
            setSelectionState={setAudiences}
            setErrorState={setAudiencesError}
            label="Audiences (pusieur choix possible)"
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <DropMultiSelect
            options={getPlacesOfIntervention()}
            error={placesOfInterventionError}
            setSelectionState={setPlacesOfIntervention}
            setErrorState={setPlacesOfInterventionError}
            label="Lieu d'Intervention (pusieur choix possible)"
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <DropMultiSelect
            options={getMissions()}
            error={missionsError}
            setSelectionState={setMissions}
            setErrorState={setMissionsError}
            label="Mission (pusieur choix possible)"
          />
        </Grid>

        <Grid item xs={12}>
          <Text>Présentation personnalisée de vos missions</Text>
        </Grid>
        <Grid item xs={12}>
          <TextInput
            error={descriptionError}
            setTextState={setDescription}
            setErrorState={setDescriptionError}
            label="Présentation"
            multiline={true}
          />
        </Grid>
        <Grid item xs={12}>
          <SingleCheckbox
            stateCheck={accept}
            error={acceptError}
            setErrorState={setAcceptError}
            setStateCheck={setAccept}
            label={
              "J'accepte d'apparître sur le répoire de partenaires du réseau d'Accueil pour tous et ainsi d'être solicité si besoin en tant que personne ressource."
            }
          />
        </Grid>
        <Grid item xs={12}>
          <Button variant="contained" fullWidth={true} onClick={onSubmit}>
            Submit
          </Button>
        </Grid>
      </Grid>
    </Box>
  );
}